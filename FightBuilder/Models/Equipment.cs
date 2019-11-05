using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FightBuilder.Other;

namespace FightBuilder.Models
{
    public class Equipment
    {
        private string type;

        public string Type
        {
            get { return type; }
            set
            {
                if (Array.Exists(Logic.TypeValidation, element => element == value))
                {
                    type = value;
                }
                else
                    throw new Exception(value + " is not an equipment type.");
            }
        }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Color { get; set; }
        public int PhysDam { get; set; }
        public int MagDam { get; set; }
        public int FireDam { get; set; }
        public int PhysDef { get; set; }
        public int MagDef { get; set; }
        public int FireDef { get; set; }
    }
}
