using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FightBuilder.Repositories;
using System.ComponentModel.DataAnnotations;

namespace FightBuilder.Models
{
    public class Fighter
    {
        private string color;

        public int FighterID { get; set; }

        [Required(ErrorMessage = "Please enter a name for your fighter.")]
        public string Name { get; set; }
        public string Description { get; set; }
        public string Color
        {
            get { return color; }
            set
            {
                //Can only be set as one of the strings from the Logic class
                if (Array.Exists(Logic.ColorValidation, element => element == value))
                {
                    color = value;
                }
                else
                    throw new Exception(value + " is not a valid color type.");
            }
        }
        public Equipment Head { get; set; }
        public Equipment Chest { get; set; }
        public Equipment Gloves { get; set; }
        public Equipment Pants { get; set; }
        public Equipment Shoes { get; set; }
        public Equipment Ring { get; set; }
        public Equipment RightHand { get; set; }
        public Equipment LeftHand { get; set; }

        //This indexer is so throughout the app I can easily loop through the 8 equipment
        //properties by the strings from Logic.TypeValidation
        public Equipment this[string key]
        {
            get
            {
                switch (key)
                {
                    case "Head":
                        return Head;
                    case "Chest":
                        return Chest;
                    case "Gloves":
                        return Gloves;
                    case "Pants":
                        return Pants;
                    case "Shoes":
                        return Shoes;
                    case "Ring":
                        return Ring;
                    case "Right Hand":
                        return RightHand;
                    case "Left Hand":
                        return LeftHand;
                }
                return null;
            }
            set
            {
                if (Array.Exists(Logic.TypeValidation, element => element == key))
                {
                    switch(key)
                    {
                        case "Head":
                            Head = value;
                            break;
                        case "Chest":
                            Chest = value;
                            break;
                        case "Gloves":
                            Gloves = value;
                            break;
                        case "Pants":
                            Pants = value;
                            break;
                        case "Shoes":
                            Shoes = value;
                            break;
                        case "Ring":
                            Ring = value;
                            break;
                        case "Right Hand":
                            RightHand = value;
                            break;
                        case "Left Hand":
                            LeftHand = value;
                            break;
                    }
                }
                else
                    throw new Exception(key + " is not an equipment type.");
            }
        }

        //The next 6 properties loop through all 8 equipment properties via the indexer
        //to calculate their totals
        public int TotalPhysDam
        {
            get
            {
                int total = 0;
                foreach (string type in Logic.TypeValidation)
                {
                    if (this[type] != null)
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
                    if (this[type] != null)
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
                    if (this[type] != null)
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
                    if (this[type] != null)
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
                    if (this[type] != null)
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
                    if (this[type] != null)
                        total += this[type].FireDef;
                }
                return total;
            }
        }
        public int Wins { get; set; }
        public int Losses { get; set; }
    }
}
