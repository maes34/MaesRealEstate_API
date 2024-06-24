using Microsoft.AspNetCore.Mvc;

namespace MaesRealEstate_UI.Controllers
{
    public class DefaultController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
