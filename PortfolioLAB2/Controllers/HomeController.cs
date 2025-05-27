using Microsoft.AspNetCore.Mvc;
using PortfolioLAB2.DAL;

namespace PortfolioLAB2.Controllers
{
    public class HomeController : Controller
    {
        ProjectsContext db;

        public HomeController(ProjectsContext db)
        {
            this.db = db;
        }

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
            var projekty = db.Projects.ToList();

            ViewBag.Projekty = projekty;

            return View();
        }
    }
}
