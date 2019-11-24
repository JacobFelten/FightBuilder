using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FightBuilder.Models;

namespace FightBuilder.Repositories
{
    public class FakeRepository : IRepository
    {
        private static List<Equipment> savedEquipment = new List<Equipment>();
        private static List<Fighter> savedFighters = new List<Fighter>();

        static FakeRepository()
        {
            AddTestData();
        }


        public List<Equipment> Equipment
        {
            get { return savedEquipment; }
        }

        public List<Fighter> Fighters
        {
            get { return savedFighters; }
        }

        private static void AddTestData()
        {
            savedEquipment.Add(new Equipment
            {
                Id = 1,
                Type = "Head",
                Name = "Helmet",
                Color = "Red",
                PhysDam = 10,
                MagDam = 10,
                FireDam = 10,
                PhysDef = 10,
                FireDef = 10,
                MagDef = 10
            });

            savedFighters.Add(new Fighter
            {
                Id = 1,
                Name = "Bob",
                Color = "Blue",
                ["Head"] = savedEquipment[0]
            });
        }
    }
}
