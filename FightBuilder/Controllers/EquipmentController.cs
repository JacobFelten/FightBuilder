using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using FightBuilder.Models;
using FightBuilder.Other;

namespace FightBuilder.Controllers
{
    public class EquipmentController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        
        [HttpPost]
        public RedirectToActionResult Index(Equipment equipment)
        {
            if (ModelState.IsValid)
            {
                Repository.SavedEquipment.Add(equipment);
            }
            else
            {
                int one = 1;
            }
            return RedirectToAction();
        }
    }
}