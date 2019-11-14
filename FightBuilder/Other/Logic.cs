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
    }
}
