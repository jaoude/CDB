using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using CDB.WebApi.Models;
using CDB.BLL.Abstraction;
using Microsoft.Extensions.Logging;

namespace CDB.WebApi.Controllers
{
    public class HomeController : BaseController<HomeController>
    {

        public HomeController(
            IBaseService baseService,
            ILogger<HomeController> logger) : base(logger, baseService)
        {
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
