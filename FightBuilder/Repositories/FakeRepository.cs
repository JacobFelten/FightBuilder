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
            if (savedEquipment.Count == 0 && savedFighters.Count == 0)
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
                Description = "Strong head piece.",
                Color = "Red",
                PhysDam = 10,
                MagDam = 10,
                FireDam = 10,
                PhysDef = 10,
                FireDef = 10,
                MagDef = 10
            });

            savedEquipment.Add(new Equipment
            {
                Id = 2,
                Type = "Left Hand",
                Name = "Shield",
                Description = "Good Shield",
                Color = "Sky Blue",
                PhysDam = 0,
                MagDam = 0,
                FireDam = 0,
                PhysDef = 100,
                FireDef = 20,
                MagDef = 20
            });

            savedEquipment.Add(new Equipment
            {
                Id = 3,
                Type = "Right Hand",
                Name = "Sword",
                Description = "Cool Saber",
                Color = "Green",
                PhysDam = 175,
                MagDam = 0,
                FireDam = 0,
                PhysDef = 0,
                FireDef = 0,
                MagDef = 0
            });

            savedFighters.Add(new Fighter
            {
                Id = 1,
                Name = "Bob",
                Description = "Skilled warrior.",
                Color = "Blue",
                ["Head"] = savedEquipment[0],
                Wins = 5,
                Losses = 2
            });

            savedFighters.Add(new Fighter
            {
                Id = 2,
                Name = "Billy",
                Color = "Black"
            });
        }
    }
}
