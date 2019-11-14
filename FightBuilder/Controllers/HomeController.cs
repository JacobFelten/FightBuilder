using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using FightBuilder.Models;
using FightBuilder.Other;

namespace FightBuilder.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult DesignEquipment()
        {
            return View();
        }

        public IActionResult BuildAFighter()
        {
            return View();
        }

        public IActionResult Fight()
        {
            return View();
        }

        public IActionResult DataTables()
        {
            return View(Repository.SavedEquipment);
        }
    }
}