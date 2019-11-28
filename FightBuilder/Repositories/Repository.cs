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

        public void AddFighter(Fighter fighter)
        {
            context.Fighters.Add(fighter);
            context.SaveChanges();
        }
    }
}
