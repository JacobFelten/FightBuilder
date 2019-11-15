using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FightBuilder.Models;

namespace FightBuilder.Other
{
    public static class Repository
    {
        private static List<Equipment> savedEquipment = new List<Equipment>();
        private static List<Fighter> savedFighters = new List<Fighter>();

        public static List<Equipment> SavedEquipment
        {
            get { return savedEquipment; }
        }

        public static List<Fighter> SavedFighters
        {
            get { return savedFighters; }
        }
    }
}
