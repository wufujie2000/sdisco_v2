﻿using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TepayLink.Sdisco.Web.Areas.Admin.Models.Layout;
using TepayLink.Sdisco.Web.Session;
using TepayLink.Sdisco.Web.Views;

namespace TepayLink.Sdisco.Web.Areas.Admin.Views.Shared.Components.AdminTheme7Footer
{
    public class AdminTheme7FooterViewComponent : SdiscoViewComponent
    {
        private readonly IPerRequestSessionCache _sessionCache;

        public AdminTheme7FooterViewComponent(IPerRequestSessionCache sessionCache)
        {
            _sessionCache = sessionCache;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var footerModel = new FooterViewModel
            {
                LoginInformations = await _sessionCache.GetCurrentLoginInformationsAsync()
            };

            return View(footerModel);
        }
    }
}
