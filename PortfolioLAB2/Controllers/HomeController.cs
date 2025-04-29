using Microsoft.AspNetCore.Mvc;

namespace PortfolioLAB2.Controllers
{
    public class HomeController : Controller
    {

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult CV()
        {
            return View();
        }

        public IActionResult Kontakt()
        {
            return View();
        }

        public IActionResult Omnie()
        {
            return View();
        }

        public IActionResult Projekty()
        {
            return View();
        }
    }
}
