using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace StockInAll.App.Controllers
{
    public class VendaController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
