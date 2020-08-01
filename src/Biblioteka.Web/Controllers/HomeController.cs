using Microsoft.AspNetCore.Mvc;

namespace Biblioteka.Web.Controllers
{
    public class HomeController : BibliotekaControllerBase
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            return View();
        }
    }
}