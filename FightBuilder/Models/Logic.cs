using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FightBuilder.Models;

namespace FightBuilder.Repositories
{
    public static class Logic
    {
        //2 static string arrays that are used throughout the app
        public static string[] TypeValidation { get; } = 
            { "Head", "Chest", "Gloves", "Pants", "Shoes", "Ring", "Right Hand", "Left Hand" };

        public static string[] ColorValidation { get; } =
            { "Black", "White", "Red", "Orange", "Yellow", "Green", "Sky Blue", "Blue", "Purple", "Pink" };

        //The next 3 methods are used by the views to generate a string that matches
        //one of the files in wwwroot/Images
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

        //The next 5 methods are used to calculate damage values, a winner, and a loser
        //when given 2 fighters
        public static int CalculateFireDamage(Fighter f1, Fighter f2)
        {
            int f1FireDamage = f2.TotalFireDam - f1.TotalFireDef;
            if (f1FireDamage < 0)
                f1FireDamage = 0;
            return f1FireDamage;
        }

        public static int CalculateMagicDamage(Fighter f1, Fighter f2)
        {
            int f1MagicDamage = f2.TotalMagDam - f1.TotalMagDef;
            if (f1MagicDamage < 0)
                f1MagicDamage = 0;
            return f1MagicDamage;
        }

        public static int CalculatePhysicalDamage(Fighter f1, Fighter f2)
        {
            int f1PhysicalDamage = f2.TotalPhysDam - f1.TotalPhysDef;
            if (f1PhysicalDamage < 0)
                f1PhysicalDamage = 0;
            return f1PhysicalDamage;
        }

        public static int CalculateTotalDamage(Fighter f1, Fighter f2)
        {
            return CalculateFireDamage(f1, f2) +
                CalculateMagicDamage(f1, f2) +
                CalculatePhysicalDamage(f1, f2);
        }

        public static void Fight(Fighter attacker, Fighter defender)
        {
            int attackerTotalDamage = CalculateTotalDamage(attacker, defender);
            int defenderTotalDamage = CalculateTotalDamage(defender, attacker);

            if (attackerTotalDamage > defenderTotalDamage)
            {
                defender.Wins++;
                attacker.Losses++;
            }
            else
            {
                attacker.Wins++;
                defender.Losses++;
            }
        }
    }
}
