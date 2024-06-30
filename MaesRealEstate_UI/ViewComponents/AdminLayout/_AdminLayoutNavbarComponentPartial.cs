using Microsoft.AspNetCore.Mvc;

namespace MaesRealEstate_UI.ViewComponents.AdminLayout
{
    public class _AdminLayoutNavbarComponentPartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
