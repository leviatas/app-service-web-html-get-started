﻿using Leviatas.Web.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Leviatas.Web.Controllers
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
            _logger.Log(LogLevel.Error, "Hubo un problema");
            return View();
        }

        public IActionResult Privacy()
        {
            _logger.Log(LogLevel.Error, "Hubo un problema en privacy");
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}