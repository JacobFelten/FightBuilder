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
                    equipment.Id = Repository.SavedEquipment.Count + 1;
                    Repository.SavedEquipment.Add(equipment);
                    ViewBag.EquipmentStatus = "New Equipment Saved!";
                }
                else
                {
                    Equipment e = Logic.GetEquipmentById(equipment.Id);
                    e = equipment;
                    ViewBag.EquipmentStatus = "Equipment Saved!";
                }
            }
            return View("Index", equipment);
        }
    }
}