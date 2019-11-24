using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FightBuilder.Repositories;
using System.ComponentModel.DataAnnotations;

namespace FightBuilder.Models
{
    public class Equipment
    {
        private string type;
        private string color;

        public int Id { get; set; }

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

        [Required(ErrorMessage = "Please enter a name for your equipment.")]
        //[RegularExpression(".+\\@.+\\..+", ErrorMessage = "Please enter a valid email address")]
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

        [Required(ErrorMessage = "Please enter a Physical Attack value.")]
        [RegularExpression("[0-9]{1,5}", ErrorMessage = "Please enter a 1 to 5 digit number for Physical Attack.")]
        public int PhysDam { get; set; }
        [Required(ErrorMessage = "Please enter a Magic Attack value.")]
        [RegularExpression("[0-9]{1,5}", ErrorMessage = "Please enter a 1 to 5 digit number for Magic Attack.")]
        public int MagDam { get; set; }
        [Required(ErrorMessage = "Please enter a Fire Attack value.")]
        [RegularExpression("[0-9]{1,5}", ErrorMessage = "Please enter a 1 to 5 digit number for Fire Attack.")]
        public int FireDam { get; set; }
        [Required(ErrorMessage = "Please enter a Physical Defence value.")]
        [RegularExpression("[0-9]{1,5}", ErrorMessage = "Please enter a 1 to 5 digit number for Physical Defence.")]
        public int PhysDef { get; set; }
        [Required(ErrorMessage = "Please enter a Magic Defence value.")]
        [RegularExpression("[0-9]{1,5}", ErrorMessage = "Please enter a 1 to 5 digit number for Magic Defence.")]
        public int MagDef { get; set; }
        [Required(ErrorMessage = "Please enter a Fire Defence value.")]
        [RegularExpression("[0-9]{1,5}", ErrorMessage = "Please enter a 1 to 5 digit number for Fire Defence.")]
        public int FireDef { get; set; }
    }
}
