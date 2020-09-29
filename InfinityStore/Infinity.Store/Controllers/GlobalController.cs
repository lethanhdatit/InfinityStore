using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Infinity.Store.Models;
using Infinity.Data;
using Infinity.Services;
using Infinity.DTOs;
using Microsoft.AspNetCore.Localization;
using Microsoft.AspNetCore.Http;

namespace Infinity.Store.Controllers
{
    public class GlobalController : Controller
    {
        private readonly ILogger<GlobalController> _logger;
        private readonly ICategoryService  _categoryService;
        private readonly GlobalSettingService _settings;
        public GlobalController(ILogger<GlobalController> logger, ICategoryService categoryService, GlobalSettingService settings)
        {
            _logger = logger;
            _categoryService = categoryService;
            _settings = settings;
        }
      
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
        public IActionResult BuildCategories()
        {
            return Json(_categoryService.GetToShowMenu(HttpContext.Features.Get<IRequestCultureFeature>().RequestCulture.Culture.ThreeLetterISOLanguageName, _settings.Get().CATEGORY_MAX_SUB_LEVEL));
        }
        ////[HttpPost]
        //public IActionResult SetLanguage(string culture, string returnUrl)
        //{
        //    Response.Cookies.Append(
        //        CookieRequestCultureProvider.DefaultCookieName,
        //        CookieRequestCultureProvider.MakeCookieValue(new RequestCulture(culture)),
        //        new CookieOptions { Expires = DateTimeOffset.UtcNow.AddYears(1) }
        //    );

        //    return LocalRedirect(returnUrl);
        //}
    }
}
