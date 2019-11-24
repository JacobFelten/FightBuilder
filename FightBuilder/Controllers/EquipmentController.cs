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
        Logic logic;

        public EquipmentController(IRepository repository)
        {
            repo = repository;
            logic = new Logic(repository);
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
                    if (!logic.EquipmentExists(equipment.Name))
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
                    Equipment e = logic.GetEquipmentById(equipment.Id);
                    logic.CopyEquipment(equipment, e);
                    logic.UpdateFighters();
                    ViewBag.EquipmentStatus = "Equipment Saved!";
                }
            }
            return View("Index", equipment);
        }

        [HttpPost]
        public IActionResult Edit(int id)
        {
            if (id != 0)
                return View("Index", logic.GetEquipmentById(id));
            return RedirectToAction("Index");
        }
    }
}