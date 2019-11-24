using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FightBuilder.Models;

namespace FightBuilder.Repositories
{
    public class Repository : IRepository
    {
        private static List<Equipment> savedEquipment = new List<Equipment>();
        private static List<Fighter> savedFighters = new List<Fighter>();

        public List<Equipment> Equipment
        {
            get { return savedEquipment; }
        }

        public List<Fighter> Fighters
        {
            get { return savedFighters; }
        }
    }
}
