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
        public IActionResult Save(Fighter fighter)
        {
            if (ModelState.IsValid)
            {
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
    }
}