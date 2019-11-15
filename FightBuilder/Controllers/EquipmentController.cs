using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using FightBuilder.Models;
using FightBuilder.Other;

namespace FightBuilder.Controllers
{
    public class EquipmentController : Controller
    {
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
                    if (!Logic.EquipmentExists(equipment.Name))
                    {
                        equipment.Id = Repository.SavedEquipment.Count + 1;
                        Repository.SavedEquipment.Add(equipment);
                        ViewBag.EquipmentStatus = "New Equipment Saved!";
                    }
                    else
                    {
                        ViewBag.EquipmentDuplicate = "You've already created equipment named " + equipment.Name + ".";
                    }
                }
                else
                {
                    Equipment e = Logic.GetEquipmentById(equipment.Id);
                    Logic.CopyEquipment(equipment, e);
                    ViewBag.EquipmentStatus = "Equipment Saved!";
                }
            }
            return View("Index", equipment);
        }

        [HttpPost]
        public IActionResult Edit(int id)
        {
            if (id != 0)
                return View("Index", Logic.GetEquipmentById(id));
            return RedirectToAction("Index");
        }
    }
}