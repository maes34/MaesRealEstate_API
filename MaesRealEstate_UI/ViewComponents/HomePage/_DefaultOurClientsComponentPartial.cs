﻿using Microsoft.AspNetCore.Mvc;

namespace MaesRealEstate_UI.ViewComponents.HomePage
{
    public class _DefaultOurClientsComponentPartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();  
        }
    }
}
