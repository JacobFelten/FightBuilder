using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FightBuilder.Models;

namespace FightBuilder.Repositories
{
    public class FakeRepository : IRepository
    {
        private List<Equipment> savedEquipment = new List<Equipment>();
        private List<Fighter> savedFighters = new List<Fighter>();

        public List<Equipment> Equipment
        {
            get { return savedEquipment; }
        }

        public List<Fighter> Fighters
        {
            get { return savedFighters; }
        }

        public void AddEquipment(Equipment equipment)
        {
            equipment.EquipmentID = Equipment.Count + 1;
            Equipment.Add(equipment);
        }

        public void UpdateEquipment(Equipment equipment)
        {
            Equipment e = savedEquipment.First(equip => equip.EquipmentID == equipment.EquipmentID);
            e.Type = equipment.Type;
            e.Name = equipment.Name;
            e.Description = equipment.Description;
            e.Color = equipment.Color;
            e.PhysDam = equipment.PhysDam;
            e.MagDam = equipment.MagDam;
            e.FireDam = equipment.FireDam;
            e.PhysDef = equipment.PhysDef;
            e.MagDef = equipment.MagDef;
            e.FireDef = equipment.FireDef;
        }

        public void DeleteEquipment(Equipment equipment)
        {
            savedEquipment.Remove(equipment);
        }

        public void AddFighter(Fighter figher)
        {
            figher.FighterID = Fighters.Count + 1;
            Fighters.Add(figher);
        }

        public void UpdateFighter(Fighter fighter)
        {
            Fighter f = savedFighters.First(fight => fight.FighterID == fighter.FighterID);
            f.Name = fighter.Name;
            f.Description = fighter.Description;
            f.Color = fighter.Color;
            foreach (string type in Logic.TypeValidation)
                f[type] = fighter[type];
            f.Wins = fighter.Wins;
            f.Losses = fighter.Losses;
        }

        public void DeleteFighter(Fighter fighter)
        {
            savedFighters.Remove(fighter);
        }
    }
}
