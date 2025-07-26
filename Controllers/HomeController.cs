using Microsoft.AspNetCore.Mvc;
using PRELIM_LAB3_BSIT31A3_PIERREBENEDICT_DECASTRO.Models;
using System.Diagnostics;

namespace PRELIM_LAB3_BSIT31A3_PIERREBENEDICT_DECASTRO.Controllers
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

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
