using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FightBuilder.Models
{
    public class FighterView
    {
        public Fighter Fighter { get; set; }
        public List<Fighter> AllFighters { get; set; }
        public List<Equipment> AllEquipment { get; set; }
    }
}
