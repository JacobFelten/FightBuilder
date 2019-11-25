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
            return View(Logic.blankEquipment);
        }
        
        [HttpPost]
        public IActionResult Save(Equipment equipment)
        {
            if (ModelState.IsValid)
            {
                if (equipment.Id == 0)
                {
                    if (!EquipmentExists(equipment.Name))
                    {
                        equipment.Id = repo.Equipment.Count + 1;
                        repo.Equipment.Add(equipment);
                        ViewBag.EquipmentStatus = "New Equipment Saved!";
                    }
                    else
                    {
                        ViewBag.EquipmentDuplicate = "You've already created equipment named " + equipment.Name + ".";
                    }
                }
                else
                {
                    Equipment e = GetEquipmentById(equipment.Id);
                    Logic.CopyEquipment(equipment, e);
                    UpdateFighters();
                    ViewBag.EquipmentStatus = "Equipment Saved!";
                }
            }
            return View("Index", equipment);
        }

        [HttpPost]
        public IActionResult Edit(int id)
        {
            if (id != 0)
                return View("Index", GetEquipmentById(id));
            return RedirectToAction("Index");
        }

        #region Other Methods
        private Equipment GetEquipmentById(int id)
        {
            foreach (Equipment e in repo.Equipment)
            {
                if (e.Id == id)
                    return e;
            }
            return Logic.blankEquipment;
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
                        f[Logic.TypeValidation[i]] = Logic.blankEquipment;
                }
            }
        }
        #endregion
    }
}