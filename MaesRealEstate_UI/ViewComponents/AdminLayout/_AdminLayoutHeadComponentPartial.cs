using Microsoft.AspNetCore.Mvc;

namespace MaesRealEstate_UI.ViewComponents.AdminLayout
{
    public class _AdminLayoutHeadComponentPartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
        return View(); 
        }
    }
}
