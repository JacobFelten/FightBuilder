using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FightBuilder.Models;

namespace FightBuilder.Repositories
{
    public interface IRepository
    {
        List<Fighter> Fighters { get; }
        List<Equipment> Equipment { get; }
    }
}
