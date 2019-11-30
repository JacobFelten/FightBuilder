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
                AllEquipment = repo.Equipment
            };
            return View(equipmentView);
        }
        
        [HttpPost]
        public IActionResult Save(EquipmentView equipmentView)
        {
            if (ModelState.IsValid)
            {
                if (equipmentView.Equipment.EquipmentID == 0)
                {
                    if (!EquipmentExists(equipmentView.Equipment.Name))
                    {
                        repo.AddEquipment(equipmentView.Equipment);
                        ViewBag.EquipmentStatus = "New Equipment Saved!";
                    }
                    else
                    {
                        ViewBag.EquipmentDuplicate = "You've already created equipment named " + equipmentView.Equipment.Name + ".";
                    }
                }
                else
                {
                    repo.UpdateEquipment(equipmentView.Equipment);
                    UpdateFighters();
                    ViewBag.EquipmentStatus = "Equipment Saved!";
                }
            }
            equipmentView.AllEquipment = repo.Equipment;
            return View("Index", equipmentView);
        }

        [HttpPost]
        public IActionResult Edit(int id)
        {
            if (id != 0)
            {
                EquipmentView equipmentView = new EquipmentView
                {
                    Equipment = GetEquipmentById(id),
                    AllEquipment = repo.Equipment
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

        private void UpdateFighters()
        {
            foreach (Fighter f in repo.Fighters)
            {
                for (int i = 0; i < Logic.TypeValidation.Count(); i++)
                {
                    if (f[Logic.TypeValidation[i]].Type != Logic.TypeValidation[i])
                        f[Logic.TypeValidation[i]] = null;
                }
            }
        }
        #endregion
    }
}