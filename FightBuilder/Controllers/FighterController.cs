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

        public FighterController(IRepository repository)
        {
            repo = repository;
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
                fighter["Head"] = GetEquipmentById(head);
                fighter["Chest"] = GetEquipmentById(chest);
                fighter["Gloves"] = GetEquipmentById(gloves);
                fighter["Pants"] = GetEquipmentById(pants);
                fighter["Shoes"] = GetEquipmentById(shoes);
                fighter["Ring"] = GetEquipmentById(ring);
                fighter["Right Hand"] = GetEquipmentById(rHand);
                fighter["Left Hand"] = GetEquipmentById(lHand);

                if (fighter.Id == 0)
                {
                    if (!FighterExists(fighter.Name))
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
                    Fighter f = GetFighterById(fighter.Id);
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
                return View("Index", GetFighterById(id));
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

        private Fighter GetFighterById(int id)
        {
            foreach (Fighter f in repo.Fighters)
            {
                if (f.Id == id)
                    return f;
            }
            return null;
        }

        private bool FighterExists(string name)
        {
            foreach (Fighter f in repo.Fighters)
            {
                if (f.Name == name)
                    return true;
            }
            return false;
        }
        #endregion
    }
}