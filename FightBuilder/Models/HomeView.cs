using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FightBuilder.Models
{
    public class HomeView
    {
        public List<Fighter> Winners { get; set; }
        public List<Fighter> Losers { get; set; }
        public Equipment RandomEquipment { get; set; }
    }
}
