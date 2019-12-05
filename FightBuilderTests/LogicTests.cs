using System;
using Xunit;
using FightBuilder.Repositories;
using FightBuilder.Models;

namespace FightBuilderTests
{
    public class LogicTests
    {
        /*
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
            AddTestData(repo);
            Equipment e = new Equipment();

            //Act
            Logic.CopyEquipment(repo.Equipment[0], e);

            //Assert
            Assert.Equal(1, e.EquipmentID);
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
            AddTestData(repo);
            Fighter f = new Fighter();

            //Act
            Logic.CopyFighter(repo.Fighters[0], f);

            //Assert
            Assert.Equal(1, f.FighterID);
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
        */

        [Fact]
        public void GeneratePicColorTest()
        {
            //Arrange
            string skyBlue;
            string green;

            //Act
            skyBlue = Logic.GeneratePicColor("Sky Blue");
            green = Logic.GeneratePicColor("Green");

            //Assert
            Assert.Equal("SkyBlue", skyBlue);
            Assert.Equal("Green", green);
        }

        [Fact]
        public void GenerateEquipmentPicTest()
        {
            //Arrange
            var repo = new FakeRepository();
            AddTestData(repo);
            string e1;
            string e2;
            string e3;

            //Act
            e1 = Logic.GenerateEquipmentPic(repo.Equipment[0]);
            e2 = Logic.GenerateEquipmentPic(repo.Equipment[1]);
            e3 = Logic.GenerateEquipmentPic(repo.Equipment[2]);

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
            AddTestData(repo);
            string f1;
            string f2;

            //Act
            f1 = Logic.GenerateFighterPic(repo.Fighters[0]);
            f2 = Logic.GenerateFighterPic(repo.Fighters[1]);

            //Assert
            Assert.Equal("FighterBlue.jpg", f1);
            Assert.Equal("FighterBlack.jpg", f2);
        }

        [Fact]
        public void CalculateFireDamageTest()
        {
            //Arrange
            var repo = new FakeRepository();
            AddTestData(repo);
            AddTestData2(repo);
            Fighter f1 = repo.Fighters[0];
            f1["Head"] = null;
            f1["Right Hand"] = repo.Equipment[3];
            Fighter f2 = repo.Fighters[1];
            f2["Left Hand"] = repo.Equipment[4];
            int f1FireDamage;
            int f2FireDamage;

            //Act
            f1FireDamage = Logic.CalculateFireDamage(f1, f2);
            f2FireDamage = Logic.CalculateFireDamage(f2, f1);

            //Assert
            Assert.Equal(0, f1FireDamage);
            Assert.Equal(10, f2FireDamage);
        }

        [Fact]
        public void CalculateMagicDamageTest()
        {
            //Arrange
            var repo = new FakeRepository();
            AddTestData(repo);
            AddTestData2(repo);
            Fighter f1 = repo.Fighters[0];
            f1["Head"] = null;
            f1["Right Hand"] = repo.Equipment[3];
            Fighter f2 = repo.Fighters[1];
            f2["Left Hand"] = repo.Equipment[4];
            int f1MagicDamage;
            int f2MagicDamage;

            //Act
            f1MagicDamage = Logic.CalculateMagicDamage(f1, f2);
            f2MagicDamage = Logic.CalculateMagicDamage(f2, f1);

            //Assert
            Assert.Equal(0, f1MagicDamage);
            Assert.Equal(10, f2MagicDamage);
        }

        [Fact]
        public void CalculatePhysicalDamageTest()
        {
            //Arrange
            var repo = new FakeRepository();
            AddTestData(repo);
            AddTestData2(repo);
            Fighter f1 = repo.Fighters[0];
            f1["Head"] = null;
            f1["Right Hand"] = repo.Equipment[3];
            Fighter f2 = repo.Fighters[1];
            f2["Left Hand"] = repo.Equipment[4];
            int f1PhysicalDamage;
            int f2PhysicalDamage;

            //Act
            f1PhysicalDamage = Logic.CalculatePhysicalDamage(f1, f2);
            f2PhysicalDamage = Logic.CalculatePhysicalDamage(f2, f1);

            //Assert
            Assert.Equal(0, f1PhysicalDamage);
            Assert.Equal(10, f2PhysicalDamage);
        }

        [Fact]
        public void CalculateTotalDamageTest()
        {
            //Arrange
            var repo = new FakeRepository();
            AddTestData(repo);
            AddTestData2(repo);
            Fighter f1 = repo.Fighters[0];
            f1["Head"] = null;
            f1["Right Hand"] = repo.Equipment[3];
            Fighter f2 = repo.Fighters[1];
            f2["Left Hand"] = repo.Equipment[4];
            int f1TotalDamage;
            int f2TotalDamage;

            //Act
            f1TotalDamage = Logic.CalculateTotalDamage(f1, f2);
            f2TotalDamage = Logic.CalculateTotalDamage(f2, f1);

            //Assert
            Assert.Equal(0, f1TotalDamage);
            Assert.Equal(30, f2TotalDamage);
        }

        [Fact]
        public void FightTest()
        {
            //Arrange
            var repo = new FakeRepository();
            AddTestData(repo);
            AddTestData2(repo);
            Fighter f1 = repo.Fighters[0];
            f1["Right Hand"] = repo.Equipment[3];
            Fighter f2 = repo.Fighters[1];
            f2["Left Hand"] = repo.Equipment[4];
            Fighter f3 = repo.Fighters[2];
            f3["Left Hand"] = repo.Equipment[4];

            //Act
            Logic.Fight(f1, f2);
            Logic.Fight(f3, f2);

            //Assert
            Assert.Equal(6, f1.Wins);
            Assert.Equal(2, f1.Losses);
            Assert.Equal(0, f2.Wins);
            Assert.Equal(2, f2.Losses);
            Assert.Equal(1, f3.Wins);
            Assert.Equal(0, f3.Losses);
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

        private void AddTestData2(FakeRepository repo)
        {
            repo.Equipment.Add(new Equipment
            {
                EquipmentID = 4,
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

            repo.Equipment.Add(new Equipment
            {
                EquipmentID = 5,
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

            repo.Fighters.Add(new Fighter
            {
                FighterID = 3,
                Name = "Jessica",
                Color = "Pink"
            });
        }
    }
}
