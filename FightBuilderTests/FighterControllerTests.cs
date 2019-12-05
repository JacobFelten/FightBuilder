using System;
using Xunit;
using FightBuilder.Repositories;
using FightBuilder.Models;
using FightBuilder.Controllers;

namespace FightBuilderTests
{
    public class FighterControllerTests
    {
        [Fact]
        public void SaveTest()
        {
            //Arrange
            var repo = new FakeRepository();
            AddTestData(repo);
            var controller = new FighterController(repo);
            var f = new Fighter()
            {
                FighterID = 0,
                Name = "Jane",
                Description = "Strong Fighter.",
                Color = "Purple",
                Wins = 3,
                Losses = 6
            };
            var fV = new FighterView()
            {
                Fighter = f
            };

            //Act
            controller.Save(fV, 1, -1, -1, -1, -1, -1, 3, 2);

            //Assert
            Assert.Equal(3, repo.Fighters.Count);
            Assert.Equal(3, repo.Fighters[2].FighterID);
            Assert.Equal("Jane", repo.Fighters[2].Name);
            Assert.Equal(repo.Equipment[0], repo.Fighters[2]["Head"]);
            Assert.Null(repo.Fighters[2]["Chest"]);
            Assert.Null(repo.Fighters[2]["Gloves"]);
            Assert.Null(repo.Fighters[2]["Pants"]);
            Assert.Null(repo.Fighters[2]["Shoes"]);
            Assert.Null(repo.Fighters[2]["Ring"]);
            Assert.Equal(repo.Equipment[1], repo.Fighters[2]["Left Hand"]);
            Assert.Equal(repo.Equipment[2], repo.Fighters[2]["Right Hand"]);
        }

        [Fact]
        public void SaveSameNameTest()
        {
            //Arrange
            var repo = new FakeRepository();
            AddTestData(repo);
            var controller = new FighterController(repo);
            var f = new Fighter()
            {
                FighterID = 0,
                Name = "Bob",
                Description = "Strong Fighter.",
                Color = "Purple",
                Wins = 3,
                Losses = 6
            };
            var fV = new FighterView()
            {
                Fighter = f
            };

            //Act
            controller.Save(fV, 1, -1, -1, -1, -1, -1, 2, 3);

            //Assert
            Assert.Equal(2, repo.Fighters.Count);
        }

        [Fact]
        public void SaveAnEditTest()
        {
            //Arrange
            var repo = new FakeRepository();
            AddTestData(repo);
            var controller = new FighterController(repo);
            var f = new Fighter()
            {
                FighterID = 2,
                Name = "Jane",
                Description = "Strong Fighter.",
                Color = "Purple",
                Wins = 3,
                Losses = 6
            };
            var fV = new FighterView()
            {
                Fighter = f
            };

            //Act
            controller.Save(fV, 1, -1, -1, -1, -1, -1, 3, 2);

            //Assert
            Assert.Equal(2, repo.Fighters.Count);
            Assert.Equal(2, repo.Fighters[1].FighterID);
            Assert.Equal("Jane", repo.Fighters[1].Name);
            Assert.Equal(repo.Equipment[0], repo.Fighters[1]["Head"]);
            Assert.Null(repo.Fighters[1]["Chest"]);
            Assert.Null(repo.Fighters[1]["Gloves"]);
            Assert.Null(repo.Fighters[1]["Pants"]);
            Assert.Null(repo.Fighters[1]["Shoes"]);
            Assert.Null(repo.Fighters[1]["Ring"]);
            Assert.Equal(repo.Equipment[1], repo.Fighters[1]["Left Hand"]);
            Assert.Equal(repo.Equipment[2], repo.Fighters[1]["Right Hand"]);
        }

        private void AddTestData(FakeRepository repo)
        {
            repo.Equipment.Add(new Equipment
            {
                EquipmentID = 1,
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

            repo.Equipment.Add(new Equipment
            {
                EquipmentID = 2,
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

            repo.Equipment.Add(new Equipment
            {
                EquipmentID = 3,
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

            repo.Fighters.Add(new Fighter
            {
                FighterID = 1,
                Name = "Bob",
                Description = "Skilled warrior.",
                Color = "Blue",
                ["Head"] = repo.Equipment[0],
                Wins = 5,
                Losses = 2
            });

            repo.Fighters.Add(new Fighter
            {
                FighterID = 2,
                Name = "Billy",
                Color = "Black"
            });
        }
    }
}
