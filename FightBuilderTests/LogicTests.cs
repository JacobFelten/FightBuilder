using System;
using Xunit;
using FightBuilder.Repositories;
using FightBuilder.Models;

namespace FightBuilderTests
{
    public class LogicTests
    {
        [Fact]
        public void GetEquipmentByIdTest()
        {
            //Arrange
            var repo = new FakeRepository();
            var logic = new Logic(repo);
            string e1;
            string e2;

            //Act
            e1 = logic.GetEquipmentById(1).Name;
            e2 = logic.GetEquipmentById(2).Name;

            //Assert
            Assert.Equal("Helmet", e1);
            Assert.Equal("Shield", e2);
        }

        [Fact]
        public void GetFighterByIdTest()
        {
            //Arrange
            var repo = new FakeRepository();
            var logic = new Logic(repo);
            string f1;
            string f2;

            //Act
            f1 = logic.GetFighterById(1).Name;
            f2 = logic.GetFighterById(2).Name;

            //Assert
            Assert.Equal("Bob", f1);
            Assert.Equal("Billy", f2);
        }
        
        [Fact]
        public void EquipmentExistsTest()
        {
            //Arrange
            var repo = new FakeRepository();
            var logic = new Logic(repo);
            bool t;
            bool f;

            //Act
            t = logic.EquipmentExists("Helmet");
            f = logic.EquipmentExists("Doesn't");

            //Assert
            Assert.True(t);
            Assert.False(f);
        }

        [Fact]
        public void FighterExistsTest()
        {
            //Arrange
            var repo = new FakeRepository();
            var logic = new Logic(repo);
            bool t;
            bool f;

            //Act
            t = logic.FighterExists("Bob");
            f = logic.FighterExists("Doesn't");

            //Assert
            Assert.True(t);
            Assert.False(f);
        }

        [Fact]
        public void CopyEquipmentTest()
        {
            //Arrange
            var repo = new FakeRepository();
            var logic = new Logic(repo);
            Equipment e = new Equipment();

            //Act
            logic.CopyEquipment(repo.Equipment[0], e);

            //Assert
            Assert.Equal(1, e.Id);
            Assert.Equal("Head", e.Type);
            Assert.Equal("Helmet", e.Name);
            Assert.Equal("Strong head piece.", e.Description);
            Assert.Equal("Red", e.Color);
            Assert.Equal(10, e.PhysDam);
            Assert.Equal(10, e.MagDam);
            Assert.Equal(10, e.FireDam);
            Assert.Equal(10, e.PhysDef);
            Assert.Equal(10, e.MagDef);
            Assert.Equal(10, e.FireDef);
        }

        [Fact]
        public void CopyFighterTest()
        {
            //Arrange
            var repo = new FakeRepository();
            var logic = new Logic(repo);
            Fighter f = new Fighter();

            //Act
            logic.CopyFighter(repo.Fighters[0], f);

            //Assert
            Assert.Equal(1, f.Id);
            Assert.Equal("Bob", f.Name);
            Assert.Equal("Skilled warrior.", f.Description);
            Assert.Equal("Blue", f.Color);
            Assert.Equal("Helmet", f["Head"].Name);
            Assert.Equal(Logic.blankEquipment, f["Chest"]);
            Assert.Equal(Logic.blankEquipment, f["Gloves"]);
            Assert.Equal(Logic.blankEquipment, f["Pants"]);
            Assert.Equal(Logic.blankEquipment, f["Shoes"]);
            Assert.Equal(Logic.blankEquipment, f["Ring"]);
            Assert.Equal(Logic.blankEquipment, f["Right Hand"]);
            Assert.Equal(Logic.blankEquipment, f["Left Hand"]);
            Assert.Equal(5, f.Wins);
            Assert.Equal(2, f.Losses);
        }

        [Fact]
        public void UpdateFightersTest()
        {
            //Arrange
            var repo = new FakeRepository();
            var logic = new Logic(repo);
            repo.Equipment[0].Type = "Chest";

            //Act
            logic.UpdateFighters();

            //Assert
            Assert.Equal(Logic.blankEquipment, repo.Fighters[0]["Head"]);
            Assert.Equal(Logic.blankEquipment, repo.Fighters[0]["Chest"]);
        }

        [Fact]
        public void GeneratePicColorTest()
        {
            //Arrange
            var repo = new FakeRepository();
            var logic = new Logic(repo);
            string skyBlue;
            string green;

            //Act
            skyBlue = logic.GeneratePicColor("Sky Blue");
            green = logic.GeneratePicColor("Green");

            //Assert
            Assert.Equal("SkyBlue", skyBlue);
            Assert.Equal("Green", green);
        }

        [Fact]
        public void GenerateEquipmentPicTest()
        {
            //Arrange
            var repo = new FakeRepository();
            var logic = new Logic(repo);
            string e1;
            string e2;
            string e3;

            //Act
            e1 = logic.GenerateEquipmentPic(repo.Equipment[0]);
            e2 = logic.GenerateEquipmentPic(repo.Equipment[1]);
            e3 = logic.GenerateEquipmentPic(repo.Equipment[2]);

            //Assert
            Assert.Equal("HeadRed.jpg", e1);
            Assert.Equal("ShieldSkyBlue.jpg", e2);
            Assert.Equal("SwordGreen.jpg", e3);
        }

        [Fact]
        public void GenerateFighterPicTest()
        {
            //Arrange
            var repo = new FakeRepository();
            var logic = new Logic(repo);
            string f1;
            string f2;

            //Act
            f1 = logic.GenerateFighterPic(repo.Fighters[0]);
            f2 = logic.GenerateFighterPic(repo.Fighters[1]);

            //Assert
            Assert.Equal("FighterBlue.jpg", f1);
            Assert.Equal("FighterBlack.jpg", f2);
        }
    }
}
