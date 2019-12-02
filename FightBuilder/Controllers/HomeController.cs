using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using FightBuilder.Models;
using FightBuilder.Repositories;

namespace FightBuilder.Controllers
{
    public class HomeController : Controller
    {
        IRepository repo;

        public HomeController(IRepository repository)
        {
            repo = repository;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Fight()
        {
            FightView fightView = new FightView
            {
                Fighter1 = new Fighter(),
                Fighter2 = new Fighter(),
                AllFighters = repo.Fighters,
                ReadyToFight = false,
                FightOver = false,
                IsCloneFight = false
            };
            return View(fightView);
        }

        [HttpPost]
        public IActionResult Fight(int fighter1Id, int fighter2Id)
        {
            FightView fightView = new FightView
            {
                Fighter1 = repo.Fighters.First(fighter => fighter.FighterID == fighter1Id),
                Fighter2 = repo.Fighters.First(fighter => fighter.FighterID == fighter2Id),
                AllFighters = repo.Fighters,
                ReadyToFight = true,
                FightOver = false,
                IsCloneFight = false
            };
            return View(fightView);
        }

        public IActionResult FightStart(int fighter1Id, int fighter2Id)
        {
            FightView fightView = new FightView
            {
                Fighter1 = repo.Fighters.First(fighter => fighter.FighterID == fighter1Id),
                Fighter2 = repo.Fighters.First(fighter => fighter.FighterID == fighter2Id),
                AllFighters = repo.Fighters,
                ReadyToFight = false,
                FightOver = true,
                IsCloneFight = false
            };
            if (fightView.Fighter1.FighterID == fightView.Fighter2.FighterID)
                fightView.IsCloneFight = true;
            fightView.Fighter1Damage = Logic.CalculateTotalDamage(fightView.Fighter1, fightView.Fighter2);
            fightView.Fighter2Damage = Logic.CalculateTotalDamage(fightView.Fighter2, fightView.Fighter1);
            Logic.Fight(fightView.Fighter1, fightView.Fighter2);
            repo.UpdateFighter(fightView.Fighter1);
            repo.UpdateFighter(fightView.Fighter2);

            return View("Fight", fightView);
        }

        public IActionResult DataTables()
        {
            return View(true);
        }

        public IActionResult FighterTable()
        {
            return View(repo.Fighters);
        }

        public IActionResult FighterSearch(string search)
        {
            List<Fighter> fighters = new List<Fighter>();
            foreach (Fighter f in repo.Fighters)
            {
                if (f.Name.Contains(search))
                    fighters.Add(f);
            }
            return View("FighterTable", fighters);
        }

        public IActionResult FighterDelete(int fighterId)
        {
            Fighter fighter = repo.Fighters.First(f => f.FighterID == fighterId);
            repo.DeleteFighter(fighter);
            return View("DataTables", true);
        }

        public IActionResult EquipmentTable()
        {
            FighterView fighterView = new FighterView()
            {
                AllEquipment = repo.Equipment,
                AllFighters = repo.Fighters
            };
            return View(fighterView);
        }

        public IActionResult EquipmentSearch(string search)
        {
            List<Equipment> equipment = new List<Equipment>();
            foreach (Equipment e in repo.Equipment)
            {
                if (e.Name.Contains(search))
                    equipment.Add(e);
            }
            FighterView fighterView = new FighterView()
            {
                AllEquipment = equipment,
                AllFighters = repo.Fighters
            };
            return View("EquipmentTable", fighterView);
        }

        public IActionResult EquipmentDelete(int equipmentId)
        {
            Equipment equipment = repo.Equipment.First(e => e.EquipmentID == equipmentId);
            foreach (Fighter f in repo.Fighters)
            {
                foreach (string type in Logic.TypeValidation)
                {
                    if (f[type] == equipment)
                        return View("DataTables", false);
                }
            }
            repo.DeleteEquipment(equipment);
            return View("DataTables", true);
        }
    }
}