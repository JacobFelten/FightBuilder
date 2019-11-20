using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using FightBuilder.Other;
using FightBuilder.Models;

namespace FightBuilder.Controllers
{
    public class FighterController : Controller
    {
        public IActionResult Index()
        {
            return View(Logic.blankFighter);
        }

        [HttpPost]
        public IActionResult Save(Fighter fighter, int head, int chest, int gloves, int pants, int shoes, int ring, int rHand, int lHand)
        {
            if (ModelState.IsValid)
            {
                fighter["Head"] = Logic.GetEquipmentById(head);
                fighter["Chest"] = Logic.GetEquipmentById(chest);
                fighter["Gloves"] = Logic.GetEquipmentById(gloves);
                fighter["Pants"] = Logic.GetEquipmentById(pants);
                fighter["Shoes"] = Logic.GetEquipmentById(shoes);
                fighter["Ring"] = Logic.GetEquipmentById(ring);
                fighter["Right Hand"] = Logic.GetEquipmentById(rHand);
                fighter["Left Hand"] = Logic.GetEquipmentById(lHand);

                if (fighter.Id == 0)
                {
                    if (!Logic.FighterExists(fighter.Name))
                    {
                        fighter.Id = Repository.SavedFighters.Count + 1;
                        Repository.SavedFighters.Add(fighter);
                        ViewBag.EquipmentStatus = "New Fighter Saved!";
                    }
                    else
                    {
                        ViewBag.EquipmentDuplicate = "You've already created a fighter named " + fighter.Name + ".";
                    }
                }
                else
                {
                    Fighter f = Logic.GetFighterById(fighter.Id);
                    Logic.CopyFighter(fighter, f);
                    ViewBag.EquipmentStatus = "Fighter Saved!";
                }
            }
            return View("Index", fighter);
        }

        [HttpPost]
        public IActionResult Edit(int id)
        {
            if (id != 0)
                return View("Index", Logic.GetFighterById(id));
            return RedirectToAction("Index");
        }
    }
}