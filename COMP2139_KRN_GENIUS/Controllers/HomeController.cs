using COMP2139_KRN_GENIUS.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace COMP2139_KRN_GENIUS.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Technicians()
        {
            return View();
        }
        public IActionResult Customers()
        {
            return View();
        }
        public IActionResult Incidents()
        {
            return View();
        }
        public IActionResult Registrations()
        {
            return View();
        }
        public IActionResult UpdateIncident()
        {
            return View();
        }

        public IActionResult About()
        {
            return View();
        }
    }
}