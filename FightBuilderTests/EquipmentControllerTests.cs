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
            var controller = new EquipmentController(repo);
            var e = new Equipment()
            {
                Id = 2,
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
            Assert.Equal(2, repo.Equipment[1].Id);
            Assert.Equal("Steel Legs", repo.Equipment[1].Name);
        }
    }
}
