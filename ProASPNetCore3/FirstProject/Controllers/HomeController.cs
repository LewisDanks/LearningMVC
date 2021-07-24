using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using FirstProject.Models;

namespace FirstProject.Controllers
{
    public class HomeController : Controller
    {
<<<<<<< HEAD
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

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
=======
        public ViewResult Index()
        {
            int currentHour = DateTime.Now.Hour;
            // is the hour less than 12 (out of 24) if so, it's morning so set viewmodel to good morning.  Else set to Good Afternoon
            string viewModel = currentHour < 12 ? "Good Morning" : "Good Afternoon";
            return View("MyView", viewModel);
>>>>>>> 10df0011d0189398120a3686403b11392ef66c4e
        }
    }
}
