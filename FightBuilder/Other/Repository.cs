using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FightBuilder.Models;

namespace FightBuilder.Other
{
    public static class Repository
    {
        private static List<Equipment> equipment = new List<Equipment>();

        public static List<Equipment> SavedEquipment
        {
            get { return equipment; }
        }
    }
}
