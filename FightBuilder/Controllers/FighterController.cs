using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using FightBuilder.Repositories;
using FightBuilder.Models;

namespace FightBuilder.Controllers
{
    public class FighterController : Controller
    {
        IRepository repo;
        Logic logic;

        public FighterController(IRepository repository)
        {
            repo = repository;
            logic = new Logic(repository);
        }

        public IActionResult Index()
        {
            return View(Logic.blankFighter);
        }

        [HttpPost]
        public IActionResult Save(Fighter fighter, int head, int chest, int gloves, int pants, int shoes, int ring, int rHand, int lHand)
        {
            if (ModelState.IsValid)
            {
                fighter["Head"] = logic.GetEquipmentById(head);
                fighter["Chest"] = logic.GetEquipmentById(chest);
                fighter["Gloves"] = logic.GetEquipmentById(gloves);
                fighter["Pants"] = logic.GetEquipmentById(pants);
                fighter["Shoes"] = logic.GetEquipmentById(shoes);
                fighter["Ring"] = logic.GetEquipmentById(ring);
                fighter["Right Hand"] = logic.GetEquipmentById(rHand);
                fighter["Left Hand"] = logic.GetEquipmentById(lHand);

                if (fighter.Id == 0)
                {
                    if (!logic.FighterExists(fighter.Name))
                    {
                        fighter.Id = repo.Fighters.Count + 1;
                        repo.Fighters.Add(fighter);
                        ViewBag.EquipmentStatus = "New Fighter Saved!";
                    }
                    else
                    {
                        ViewBag.EquipmentDuplicate = "You've already created a fighter named " + fighter.Name + ".";
                    }
                }
                else
                {
                    Fighter f = logic.GetFighterById(fighter.Id);
                    logic.CopyFighter(fighter, f);
                    ViewBag.EquipmentStatus = "Fighter Saved!";
                }
            }
            return View("Index", fighter);
        }

        [HttpPost]
        public IActionResult Edit(int id)
        {
            if (id != 0)
                return View("Index", logic.GetFighterById(id));
            return RedirectToAction("Index");
        }
    }
}