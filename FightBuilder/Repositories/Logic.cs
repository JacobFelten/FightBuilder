using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FightBuilder.Models;

namespace FightBuilder.Repositories
{
    public class Logic
    {
        IRepository repo;

        public Logic(IRepository repository)
        {
            repo = repository;
        }

        public static string[] TypeValidation { get; } = 
            { "Head", "Chest", "Gloves", "Pants", "Shoes", "Ring", "Right Hand", "Left Hand" };

        public static string[] ColorValidation { get; } =
            { "Black", "White", "Red", "Orange", "Yellow", "Green", "Sky Blue", "Blue", "Purple", "Pink" };

        public static Equipment blankEquipment = new Equipment();

        public static Fighter blankFighter = new Fighter();

        public Equipment GetEquipmentById(int id)
        {
            foreach (Equipment e in repo.Equipment)
            {
                if (e.Id == id)
                    return e;
            }
            return blankEquipment;
        }

        public Fighter GetFighterById(int id)
        {
            foreach (Fighter f in repo.Fighters)
            {
                if (f.Id == id)
                    return f;
            }
            return null;
        }

        public bool EquipmentExists(string name)
        {
            foreach (Equipment e in repo.Equipment)
            {
                if (e.Name == name)
                    return true;
            }
            return false;
        }

        public bool FighterExists(string name)
        {
            foreach (Fighter f in repo.Fighters)
            {
                if (f.Name == name)
                    return true;
            }
            return false;
        }

        public void CopyEquipment(Equipment original, Equipment copy)
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

        public void CopyFighter(Fighter original, Fighter copy)
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

        public void UpdateFighters()
        {
            foreach (Fighter f in repo.Fighters)
            {
                for (int i = 0; i < TypeValidation.Count(); i++)
                {
                    if (f[TypeValidation[i]].Type != TypeValidation[i])
                        f[TypeValidation[i]] = blankEquipment;
                }
            }
        }

        public string GeneratePicColor(string color)
        {
            if (color == "Sky Blue")
                return "SkyBlue";
            return color;
        }

        public string GenerateEquipmentPic(Equipment e)
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

        public string GenerateFighterPic(Fighter f)
        {
            return "Fighter" + GeneratePicColor(f.Color) + ".jpg";
        }

        public int CalculateFireDamage(Fighter f1, Fighter f2)
        {
            int f1FireDamage = f2.TotalFireDam - f1.TotalFireDef;
            if (f1FireDamage < 0)
                f1FireDamage = 0;
            return f1FireDamage;
        }

        public int CalculateMagicDamage(Fighter f1, Fighter f2)
        {
            int f1MagicDamage = f2.TotalMagDam - f1.TotalMagDef;
            if (f1MagicDamage < 0)
                f1MagicDamage = 0;
            return f1MagicDamage;
        }

        public int CalculatePhysicalDamage(Fighter f1, Fighter f2)
        {
            int f1PhysicalDamage = f2.TotalPhysDam - f1.TotalPhysDef;
            if (f1PhysicalDamage < 0)
                f1PhysicalDamage = 0;
            return f1PhysicalDamage;
        }

        public int CalculateTotalDamage(Fighter f1, Fighter f2)
        {
            return CalculateFireDamage(f1, f2) +
                CalculateMagicDamage(f1, f2) +
                CalculatePhysicalDamage(f1, f2);
        }

        public void Fight(Fighter attacker, Fighter defender)
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
