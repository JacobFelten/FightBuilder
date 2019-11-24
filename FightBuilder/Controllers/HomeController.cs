using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using FightBuilder.Models;
using FightBuilder.Repositories;

namespace FightBuilder.Controllers
{
    public class HomeController : Controller
    {
        IRepository repo;

        public HomeController(IRepository repository)
        {
            repo = repository;
        }

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
            return View(repo.Fighters);
        }
    }
}