using Microsoft.AspNetCore.Mvc;

namespace MaesRealEstate_UI.Controllers
{
    public class CategoryController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
