using Microsoft.AspNetCore.Mvc;

namespace MaesRealEstate_UI.Controllers
{
    public class ProfileController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
