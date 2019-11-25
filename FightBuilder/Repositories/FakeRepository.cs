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

        public FakeRepository()
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

        private void AddTestData()
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
        
        public void AddTestData2()
        {
            savedEquipment.Add(new Equipment
            {
                Id = 4,
                Type = "Right Hand",
                Name = "Sword Attack",
                Description = "Attack",
                Color = "Red",
                PhysDam = 50,
                MagDam = 50,
                FireDam = 50,
                PhysDef = 50,
                FireDef = 50,
                MagDef = 50
            });

            savedEquipment.Add(new Equipment
            {
                Id = 5,
                Type = "Left Hand",
                Name = "Shield Defend",
                Description = "Defend",
                Color = "Blue",
                PhysDam = 40,
                MagDam = 40,
                FireDam = 40,
                PhysDef = 40,
                FireDef = 40,
                MagDef = 40
            });

            savedFighters.Add(new Fighter
            {
                Id = 3,
                Name = "Jessica",
                Color = "Pink"
            });
        }
    }
}
