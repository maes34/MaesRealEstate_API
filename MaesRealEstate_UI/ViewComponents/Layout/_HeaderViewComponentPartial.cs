using Microsoft.AspNetCore.Mvc;

namespace MaesRealEstate_UI.ViewComponents.Layout
{
    public class _HeaderViewComponentPartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
