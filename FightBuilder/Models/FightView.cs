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
    }
}
