﻿using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TepayLink.Sdisco.Web.Areas.Admin.Models.Layout;
using TepayLink.Sdisco.Web.Session;
using TepayLink.Sdisco.Web.Views;

namespace TepayLink.Sdisco.Web.Areas.Admin.Views.Shared.Components.AdminTheme9Brand
{
    public class AdminTheme9BrandViewComponent : SdiscoViewComponent
    {
        private readonly IPerRequestSessionCache _sessionCache;

        public AdminTheme9BrandViewComponent(IPerRequestSessionCache sessionCache)
        {
            _sessionCache = sessionCache;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var headerModel = new HeaderViewModel
            {
                LoginInformations = await _sessionCache.GetCurrentLoginInformationsAsync()
            };

            return View(headerModel);
        }
    }
}
