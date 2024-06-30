using Microsoft.AspNetCore.Mvc;

namespace MaesRealEstate_UI.ViewComponents.AdminLayout
{
    public class _AdminLayoutScriptComponentPartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
