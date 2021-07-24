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
        public ViewResult Index()
        {
            int currentHour = DateTime.Now.Hour;
            // is the hour less than 12 (out of 24) if so, it's morning so set viewmodel to good morning.  Else set to Good Afternoon
            string viewModel = currentHour < 12 ? "Good Morning" : "Good Afternoon";
            return View("MyView", viewModel);
        }
    }
}
