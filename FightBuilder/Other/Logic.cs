using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FightBuilder.Models;

namespace FightBuilder.Other
{
    public static class Logic
    {
        public static string[] TypeValidation { get; } = 
            { "Head", "Chest", "Gloves", "Pants", "Shoes", "Ring", "Right Hand", "Left Hand" };

        public static string[] ColorValidation { get; } =
            { "Black", "White", "Red", "Orange", "Yellow", "Green", "Sky Blue", "Blue", "Purple", "Pink" };

        public static Equipment blankEquipment = new Equipment();

        public static Fighter blankFighter = new Fighter();

        public static Equipment GetEquipmentById(int id)
        {
            foreach (Equipment e in Repository.SavedEquipment)
            {
                if (e.Id == id)
                    return e;
            }
            return null;
        }

        public static Fighter GetFighterById(int id)
        {
            foreach (Fighter f in Repository.SavedFighters)
            {
                if (f.Id == id)
                    return f;
            }
            return null;
        }

        public static bool EquipmentExists(string name)
        {
            foreach (Equipment e in Repository.SavedEquipment)
            {
                if (e.Name == name)
                    return true;
            }
            return false;
        }

        public static bool FighterExists(string name)
        {
            foreach (Fighter f in Repository.SavedFighters)
            {
                if (f.Name == name)
                    return true;
            }
            return false;
        }

        public static void CopyEquipment(Equipment original, Equipment copy)
        {
            copy.Id = original.Id;
            copy.Name = original.Name;
            copy.Type = original.Type;
            copy.Description = original.Description;
            copy.Color = original.Color;
            copy.PhysDam = original.PhysDam;
            copy.MagDam = original.MagDam;
            copy.FireDam = original.FireDam;
            copy.PhysDef = original.PhysDef;
            copy.MagDef = original.MagDef;
            copy.FireDef = original.FireDef;
        }

        public static void CopyFighter(Fighter original, Fighter copy)
        {
            copy.Id = original.Id;
            copy.Name = original.Name;
            copy.Description = original.Description;
            copy.Color = original.Color;
            foreach (string type in TypeValidation)
            {
                copy[type] = original[type];
            }
            copy.Wins = original.Wins;
            copy.Losses = original.Losses;
        }

        public static string GeneratePicColor(string color)
        {
            if (color == "Sky Blue")
                return "SkyBlue";
            return color;
        }

        public static string GenerateEquipmentPic(Equipment e)
        {
            string pic = "";

            if (e.Type == "Right Hand")
                pic += "Sword";
            else if (e.Type == "Left Hand")
                pic += "Shield";
            else
                pic += e.Type;

            return pic + GeneratePicColor(e.Color) + ".jpg";
        }

        public static string GenerateFighterPic(Fighter f)
        {
            return "Fighter" + GeneratePicColor(f.Color) + ".jpg";
        }
    }
}
