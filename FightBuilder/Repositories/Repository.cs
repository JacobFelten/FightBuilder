using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FightBuilder.Models;

namespace FightBuilder.Repositories
{
    public class Repository : IRepository
    {
        private AppDbContext context;

        public Repository(AppDbContext appDbContext)
        {
            context = appDbContext;
        }

        public List<Equipment> Equipment
        {
            get { return context.Equipment.ToList(); }
        }

        public List<Fighter> Fighters
        {
            get { return context.Fighters.ToList(); }
        }

        public void AddEquipment(Equipment equipment)
        {
            context.Equipment.Add(equipment);
            context.SaveChanges();
        }

        public void UpdateEquipment(Equipment equipment)
        {
            Equipment e = context.Equipment.First(equip => equip.EquipmentID == equipment.EquipmentID);
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
            context.Equipment.Update(e);
            context.SaveChanges();
        }

        public void AddFighter(Fighter fighter)
        {
            context.Fighters.Add(fighter);
            context.SaveChanges();
        }

        public void UpdateFighter(Fighter fighter)
        {
            Fighter f = context.Fighters.First(fight => fight.FighterID == fighter.FighterID);
            f.Name = fighter.Name;
            f.Description = fighter.Description;
            f.Color = fighter.Color;
            foreach (string type in Logic.TypeValidation)
                f[type] = fighter[type];
            f.Wins = fighter.Wins;
            f.Losses = fighter.Losses;
            context.Fighters.Update(f);
            context.SaveChanges();
        }
    }
}
