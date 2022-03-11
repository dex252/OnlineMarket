using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using OnlineMarket.Repositories;
using OnlineMarket.ViewModels.Home;
using OnlineMarket.ViewModels.Shared.Errors;

namespace Web.Controllers
{
    public class HomeController : Controller
    {
        private ILogger<HomeController> Log { get; }

        public HomeController(ILogger<HomeController> log)
        {
            Log = log;
        }

        [HttpGet]
        public IActionResult Index()
        {
            var viewModel = new HomeViewModel();

            return View("~/Views/Home/Index.cshtml", viewModel);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
