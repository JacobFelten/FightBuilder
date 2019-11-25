using System;
using Xunit;
using FightBuilder.Repositories;
using FightBuilder.Models;
using FightBuilder.Controllers;

namespace FightBuilderTests
{
    public class EquipmentControllerTests
    {
        [Fact]
        public void SaveTest()
        {
            //Arrange
            var repo = new FakeRepository();
            AddTestData(repo);
            var controller = new EquipmentController(repo);
            var e = new Equipment()
            {
                Id = 0,
                Type = "Pants",
                Name = "Steel Legs",
                Description = "Lower piece of armor.",
                Color = "Orange",
                PhysDam = 0,
                MagDam = 0,
                FireDam = 0,
                PhysDef = 50,
                FireDef = 30,
                MagDef = 30
            };

            //Act
            controller.Save(e);

            //Assert
            Assert.Equal(4, repo.Equipment.Count);
            Assert.Equal(4, repo.Equipment[3].Id);
            Assert.Equal("Steel Legs", repo.Equipment[3].Name);
        }

        [Fact]
        public void SaveSameNameTest()
        {
            //Arrange
            var repo = new FakeRepository();
            AddTestData(repo);
            var controller = new EquipmentController(repo);
            var e = new Equipment()
            {
                Id = 0,
                Type = "Pants",
                Name = "Shield",
                Description = "Lower piece of armor.",
                Color = "Orange",
                PhysDam = 0,
                MagDam = 0,
                FireDam = 0,
                PhysDef = 50,
                FireDef = 30,
                MagDef = 30
            };

            //Act
            controller.Save(e);

            //Assert
            Assert.Equal(3, repo.Equipment.Count);
        }

        [Fact]
        public void SaveAnEditTest()
        {
            //Arrange
            var repo = new FakeRepository();
            AddTestData(repo);
            var controller = new EquipmentController(repo);
            var e = new Equipment()
            {
                Id = 1,
                Type = "Pants",
                Name = "Steel Legs",
                Description = "Lower piece of armor.",
                Color = "Orange",
                PhysDam = 0,
                MagDam = 0,
                FireDam = 0,
                PhysDef = 50,
                FireDef = 30,
                MagDef = 30
            };

            //Act
            controller.Save(e);

            //Assert
            Assert.Equal(3, repo.Equipment.Count);
            Assert.Equal(1, repo.Equipment[0].Id);
            Assert.Equal("Steel Legs", repo.Equipment[0].Name);
            Assert.Equal(Logic.blankEquipment, repo.Fighters[0]["Head"]);
        }

        private void AddTestData(FakeRepository repo)
        {
            repo.Equipment.Add(new Equipment
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

            repo.Equipment.Add(new Equipment
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

            repo.Equipment.Add(new Equipment
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

            repo.Fighters.Add(new Fighter
            {
                Id = 1,
                Name = "Bob",
                Description = "Skilled warrior.",
                Color = "Blue",
                ["Head"] = repo.Equipment[0],
                Wins = 5,
                Losses = 2
            });

            repo.Fighters.Add(new Fighter
            {
                Id = 2,
                Name = "Billy",
                Color = "Black"
            });
        }
    }
}
