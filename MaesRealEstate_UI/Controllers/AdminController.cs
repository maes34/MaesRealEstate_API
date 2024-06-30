using Microsoft.AspNetCore.Mvc;

namespace MaesRealEstate_UI.Controllers
{
    public class AdminController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
