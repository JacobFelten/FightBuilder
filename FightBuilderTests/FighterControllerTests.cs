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
            var controller = new FighterController(repo);
            var f = new Fighter()
            {
                Id = 0,
                Name = "Jane",
                Description = "Strong Fighter.",
                Color = "Purple",
                Wins = 3,
                Losses = 6
            };

            //Act
            controller.Save(f, 1, -1, -1, -1, -1, -1, 3, 2);

            //Assert
            Assert.Equal(3, repo.Fighters.Count);
            Assert.Equal(3, repo.Fighters[2].Id);
            Assert.Equal("Jane", repo.Fighters[2].Name);
            Assert.Equal(repo.Equipment[0], repo.Fighters[2]["Head"]);
            Assert.Equal(Logic.blankEquipment, repo.Fighters[2]["Chest"]);
            Assert.Equal(Logic.blankEquipment, repo.Fighters[2]["Gloves"]);
            Assert.Equal(Logic.blankEquipment, repo.Fighters[2]["Pants"]);
            Assert.Equal(Logic.blankEquipment, repo.Fighters[2]["Shoes"]);
            Assert.Equal(Logic.blankEquipment, repo.Fighters[2]["Ring"]);
            Assert.Equal(repo.Equipment[1], repo.Fighters[2]["Left Hand"]);
            Assert.Equal(repo.Equipment[2], repo.Fighters[2]["Right Hand"]);
        }

        [Fact]
        public void SaveSameNameTest()
        {
            //Arrange
            var repo = new FakeRepository();
            var controller = new FighterController(repo);
            var f = new Fighter()
            {
                Id = 0,
                Name = "Bob",
                Description = "Strong Fighter.",
                Color = "Purple",
                Wins = 3,
                Losses = 6
            };

            //Act
            controller.Save(f, 1, -1, -1, -1, -1, -1, 2, 3);

            //Assert
            Assert.Equal(2, repo.Fighters.Count);
        }

        [Fact]
        public void SaveAnEditTest()
        {
            //Arrange
            var repo = new FakeRepository();
            var controller = new FighterController(repo);
            var f = new Fighter()
            {
                Id = 2,
                Name = "Jane",
                Description = "Strong Fighter.",
                Color = "Purple",
                Wins = 3,
                Losses = 6
            };

            //Act
            controller.Save(f, 1, -1, -1, -1, -1, -1, 3, 2);

            //Assert
            Assert.Equal(2, repo.Fighters.Count);
            Assert.Equal(2, repo.Fighters[1].Id);
            Assert.Equal("Jane", repo.Fighters[1].Name);
            Assert.Equal(repo.Equipment[0], repo.Fighters[1]["Head"]);
            Assert.Equal(Logic.blankEquipment, repo.Fighters[1]["Chest"]);
            Assert.Equal(Logic.blankEquipment, repo.Fighters[1]["Gloves"]);
            Assert.Equal(Logic.blankEquipment, repo.Fighters[1]["Pants"]);
            Assert.Equal(Logic.blankEquipment, repo.Fighters[1]["Shoes"]);
            Assert.Equal(Logic.blankEquipment, repo.Fighters[1]["Ring"]);
            Assert.Equal(repo.Equipment[1], repo.Fighters[1]["Left Hand"]);
            Assert.Equal(repo.Equipment[2], repo.Fighters[1]["Right Hand"]);
        }
    }
}
