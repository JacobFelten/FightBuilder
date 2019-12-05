using System;
using Xunit;
using FightBuilder.Repositories;
using FightBuilder.Models;
using FightBuilder.Controllers;

namespace FightBuilderTests
{
    public class HomeControllerTests
    {
        [Fact]
        public void FightStartTest()
        {
            //Arrange
            var repo = new FakeRepository();
            var controller = new HomeController(repo);
            AddTestData(repo);

            //Act
            controller.FightStart(1, 2);

            //Assert
            Assert.Equal(6, repo.Fighters[0].Wins);
            Assert.Equal(2, repo.Fighters[0].Losses);
            Assert.Equal(0, repo.Fighters[1].Wins);
            Assert.Equal(1, repo.Fighters[1].Losses);
        }

        [Fact]
        public void FightStartCloneFightTest()
        {
            //Arrange
            var repo = new FakeRepository();
            var controller = new HomeController(repo);
            AddTestData(repo);

            //Act
            controller.FightStart(1, 1);

            //Assert
            Assert.Equal(6, repo.Fighters[0].Wins);
            Assert.Equal(3, repo.Fighters[0].Losses);
        }

        [Fact]
        public void FighterDeleteTest()
        {
            //Arrange
            var repo = new FakeRepository();
            var controller = new HomeController(repo);
            AddTestData(repo);

            //Act
            controller.FighterDelete(2);

            //Assert
            Assert.Single(repo.Fighters);
        }

        [Fact]
        public void EquipmentDeleteTest()
        {
            //Arrange
            var repo = new FakeRepository();
            var controller = new HomeController(repo);
            AddTestData(repo);

            //Act
            controller.EquipmentDelete(2);

            //Assert
            Assert.Equal(2, repo.Equipment.Count);
        }

        [Fact]
        public void EquipmentDeleteInUseTest()
        {
            //Arrange
            var repo = new FakeRepository();
            var controller = new HomeController(repo);
            AddTestData(repo);

            //Act
            controller.EquipmentDelete(1);

            //Assert
            Assert.Equal(3, repo.Equipment.Count);
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
