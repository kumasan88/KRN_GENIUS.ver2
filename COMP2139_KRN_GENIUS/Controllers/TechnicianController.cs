using Microsoft.AspNetCore.Mvc;
using COMP2139_KRN_GENIUS.Models;

namespace COMP2139_KRN_GENIUS.Controllers
{
    public class TechnicianController : Controller
    {
        private ProductContext context { get; set; }
        public TechnicianController(ProductContext ctx)
        {
            context = ctx;
        }
        public IActionResult List()
        {
            var tech = context.Technicians.OrderBy(m => m.TechnicianId).ToList();
            return View(tech);
        }

    }
<<<<<<< HEAD
}
=======
}
>>>>>>> 2909b4e3f0f71757067a18b93264121002c10910
