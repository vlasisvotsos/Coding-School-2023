﻿using Microsoft.AspNetCore.Mvc;
using PetShop.MVC.Models;
using System.Diagnostics;

namespace PetShop.MVC.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }
        public IActionResult Pet()
        {
            return View();
        }
        public IActionResult Customer()
        {
            return View();
        }
        public IActionResult Employee()
        {
            return View();
        }
        public IActionResult PetFood()
        {
            return View();
        }
        public IActionResult Transaction()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}