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

        public static Equipment GetEquipmentById(int id)
        {
            foreach (Equipment e in Repository.SavedEquipment)
            {
                if (e.Id == id)
                    return e;
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

        public static string GenerateEquipmentPic(Equipment e)
        {
            string pic = "";

            if (e.Type == "Right Hand")
                pic += "Sword";
            else if (e.Type == "Left Hand")
                pic += "Shield";
            else
                pic += e.Type;

            if (e.Color == "Sky Blue")
                pic += "SkyBlue";
            else
                pic += e.Color;

            return pic + ".jpg";
        }
    }
}
