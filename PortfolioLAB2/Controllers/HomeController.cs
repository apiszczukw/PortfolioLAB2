using Microsoft.AspNetCore.Mvc;

namespace PortfolioLAB2.Controllers
{
    public class HomeController : Controller
    {

        public IActionResult Index()
        {
            return View();
        }

        [Route("cv")]
        public IActionResult CV()
        {
            return View();
        }

        [Route("kontakt")]
        public IActionResult Kontakt()
        {
            return View();
        }

        [Route("omnie")]
        public IActionResult Omnie()
        {
            return View();
        }

        [Route("projekty")]
        public IActionResult Projekty()
        {
            return View();
        }
    }
}
