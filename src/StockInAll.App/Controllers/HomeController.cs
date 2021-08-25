using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using StockInAll.App.ViewModels;
using Microsoft.AspNetCore.Authorization;


namespace StockInAll.App.Controllers
{
    [Authorize]
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

        public IActionResult Buttons()
        {
            return View();
        }

        public IActionResult Cards()
        {
            return View();
        }

        public IActionResult Colors()
        {
            return View();
        }

        public IActionResult Borders()
        {
            return View();
        }

        public IActionResult Animations()
        {
            return View();
        }

        public IActionResult Others()
        {
            return View();
        }

        public IActionResult Login()
        {
            return View();
        }
        public IActionResult Register()
        {
            return View();
        }

        public IActionResult Forgot()
        {
            return View();
        }

        public IActionResult Charts()
        {
            return View();
        }

        public IActionResult Tables()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

       [Route("erro/{id:length(3,3)}")]
        public IActionResult Error(int id)
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }


 
    }
}
