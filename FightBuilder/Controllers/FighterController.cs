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

        //Passing the ids of each equipment to be worn by the fighter was how I chose to
        //code this method when I realized a model can't be passed as the value from
        //individual form inputs. I just pass the int ids and get the actual models that
        //will fill the fighter in this method.
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

                //Asking if it's a new fighter
                if (fighterView.Fighter.FighterID == 0)
                {
                    // Asking if it's being given a unique name
                    if (!FighterExists(fighterView.Fighter.Name))
                    {
                        repo.AddFighter(fighterView.Fighter);
                        fighterView.FighterStatus = "New Fighter Saved!";
                    }
                    //Else will update an existing fighter
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
            //This If statement might not be needed because I don't believe this method
            //will ever be called without a valid id, but it's set up to work regardless
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