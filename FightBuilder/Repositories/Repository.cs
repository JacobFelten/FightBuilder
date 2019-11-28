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
    }
}
