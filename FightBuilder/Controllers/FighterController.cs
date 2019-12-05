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
            FighterView fighterView = new FighterView
            {
                Fighter = new Fighter(),
                AllEquipment = repo.Equipment,
                AllFighters = repo.Fighters,
                Duplicate = false,
                FighterStatus = ""
            };

            return View(fighterView);
        }

        [HttpPost]
        public IActionResult Save(FighterView fighterView, int head, int chest, int gloves, int pants, int shoes, int ring, int rHand, int lHand)
        {
            if (ModelState.IsValid)
            {
                fighterView.Fighter["Head"] = GetEquipmentById(head);
                fighterView.Fighter["Chest"] = GetEquipmentById(chest);
                fighterView.Fighter["Gloves"] = GetEquipmentById(gloves);
                fighterView.Fighter["Pants"] = GetEquipmentById(pants);
                fighterView.Fighter["Shoes"] = GetEquipmentById(shoes);
                fighterView.Fighter["Ring"] = GetEquipmentById(ring);
                fighterView.Fighter["Right Hand"] = GetEquipmentById(rHand);
                fighterView.Fighter["Left Hand"] = GetEquipmentById(lHand);

                if (fighterView.Fighter.FighterID == 0)
                {
                    if (!FighterExists(fighterView.Fighter.Name))
                    {
                        repo.AddFighter(fighterView.Fighter);
                        fighterView.FighterStatus = "New Fighter Saved!";
                    }
                    else
                    {
                        fighterView.Duplicate = true;
                    }
                }
                else
                {
                    repo.UpdateFighter(fighterView.Fighter);
                    fighterView.FighterStatus = "Fighter Saved!";
                }
            }
            fighterView.AllEquipment = repo.Equipment;
            fighterView.AllFighters = repo.Fighters;
            return View("Index", fighterView);
        }

        [HttpPost]
        public IActionResult Edit(int id)
        {
            if (id != 0)
            {
                FighterView fighterView = new FighterView
                {
                    Fighter = GetFighterById(id),
                    AllEquipment = repo.Equipment,
                    AllFighters = repo.Fighters,
                    Duplicate = false,
                    FighterStatus = ""
                };
                return View("Index", fighterView);
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

        private Fighter GetFighterById(int id)
        {
            foreach (Fighter f in repo.Fighters)
            {
                if (f.FighterID == id)
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