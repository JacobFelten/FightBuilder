using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FightBuilder.Models
{
    public class FightView
    {
        public Fighter Fighter1 { get; set; }
        public Fighter Fighter2 { get; set; }
        public List<Fighter> AllFighters { get; set; }
        public bool ReadyToFight { get; set; }
        public bool FightOver { get; set; }
        public int Fighter1Damage { get; set; }
        public int Fighter2Damage { get; set; }
        public bool IsCloneFight { get; set; }
    }
}
