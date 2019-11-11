using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FightBuilder.Other;

namespace FightBuilder.Models
{
    public class Fighter
    {
        private SortedList<string, Equipment> equipment = new SortedList<string, Equipment>();
        private Equipment blank = new Equipment();
        private string color;

        public Fighter()
        {
            for (int i = 0; i < Logic.TypeValidation.Length; i++)
            {
                equipment.Add(Logic.TypeValidation[i], null);
            }
        }

        public string Name { get; set; }
        public string Description { get; set; }
        public string Color
        {
            get { return color; }
            set
            {
                if (Array.Exists(Logic.ColorValidation, element => element == value))
                {
                    color = value;
                }
                else
                    throw new Exception(value + " is not a valid color type.");
            }
        }
        public int HitPoints { get; set; }
        public Equipment this[string key]
        {
            get
            {
                if (equipment[key] == null)
                    return blank;
                return equipment[key];
            }
            set
            {
                if (Array.Exists(Logic.TypeValidation, element => element == key))
                {
                    equipment[key] = value;
                }
                else
                    throw new Exception(key + " is not an equipment type.");
            }
        }
        public int TotalPhysDam
        {
            get
            {
                int total = 0;
                foreach (string type in Logic.TypeValidation)
                {
                    total += this[type].PhysDam;
                }
                return total;
            }
        }
        public int TotalMagDam
        {
            get
            {
                int total = 0;
                foreach (string type in Logic.TypeValidation)
                {
                    total += this[type].MagDam;
                }
                return total;
            }
        }
        public int TotalFireDam
        {
            get
            {
                int total = 0;
                foreach (string type in Logic.TypeValidation)
                {
                    total += this[type].FireDam;
                }
                return total;
            }
        }
        public int TotalPhysDef
        {
            get
            {
                int total = 0;
                foreach (string type in Logic.TypeValidation)
                {
                    total += this[type].PhysDef;
                }
                return total;
            }
        }
        public int TotalMagDef
        {
            get
            {
                int total = 0;
                foreach (string type in Logic.TypeValidation)
                {
                    total += this[type].MagDef;
                }
                return total;
            }
        }
        public int TotalFireDef
        {
            get
            {
                int total = 0;
                foreach (string type in Logic.TypeValidation)
                {
                    total += this[type].FireDef;
                }
                return total;
            }
        }
        public int Wins { get; set; }
        public int Losses { get; set; }
    }
}
