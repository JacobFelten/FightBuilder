using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using FightBuilder.Models;
using FightBuilder.Repositories;

namespace FightBuilder.Controllers
{
    public class EquipmentController : Controller
    {
        IRepository repo;

        public EquipmentController(IRepository repository)
        {
            repo = repository;
        }

        public IActionResult Index()
        {
            EquipmentView equipmentView = new EquipmentView
            {
                Equipment = new Equipment(),
                AllEquipment = repo.Equipment,
                Duplicate = false,
                EquipmentStatus = ""
            };
            return View(equipmentView);
        }
        
        [HttpPost]
        public IActionResult Save(EquipmentView equipmentView)
        {
            if (ModelState.IsValid)
            {
                //Asking if it's a new equipment
                if (equipmentView.Equipment.EquipmentID == 0)
                {
                    //Asking if it's being given a unique name
                    if (!EquipmentExists(equipmentView.Equipment.Name))
                    {
                        repo.AddEquipment(equipmentView.Equipment);
                        equipmentView.EquipmentStatus = "New Equipment Saved!";
                    }
                    else
                    {
                        equipmentView.Duplicate = true;
                    }
                }
                //Else will update an existing equipment
                else
                {
                    repo.UpdateEquipment(equipmentView.Equipment);
                    UpdateFighters();
                    equipmentView.EquipmentStatus = "Equipment Saved!";
                }
            }
            equipmentView.AllEquipment = repo.Equipment;
            return View("Index", equipmentView);
        }

        [HttpPost]
        public IActionResult Edit(int id)
        {
            //This If statement might not be needed because I don't believe this method
            //will ever be called without a valid id, but it's set up to work regardless
            if (id != 0)
            {
                EquipmentView equipmentView = new EquipmentView
                {
                    Equipment = GetEquipmentById(id),
                    AllEquipment = repo.Equipment,
                    Duplicate = false,
                    EquipmentStatus = ""
                };
                return View("Index", equipmentView);
            }
            return RedirectToAction("Index");
        }

        #region Other Methods
        private Equipment GetEquipmentById(int id)
        {
            foreach (Equipment e in repo.Equipment)
            {
                if (e.EquipmentID == id)
                    return e;
            }
            return null;
        }

        private bool EquipmentExists(string name)
        {
            foreach (Equipment e in repo.Equipment)
            {
                if (e.Name == name)
                    return true;
            }
            return false;
        }

        //This method removes all equipment from fighters where the type of equipment
        //doesn't match the type wanted by the fighter. It's called whenever an equipment
        //is updated.
        private void UpdateFighters()
        {
            foreach (Fighter f in repo.Fighters)
            {
                for (int i = 0; i < Logic.TypeValidation.Count(); i++)
                {
                    if (f[Logic.TypeValidation[i]] != null && f[Logic.TypeValidation[i]].Type != Logic.TypeValidation[i])
                        f[Logic.TypeValidation[i]] = null;
                }
            }
        }
        #endregion
    }
}