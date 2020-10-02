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
    //[Route("shopping")]
    public class ShoppingController : Controller
    {
        private readonly ILogger<ShoppingController> _logger;
        private readonly ICategoryService  _categoryService;
        private readonly GlobalSettingService _settings;
        public ShoppingController(ILogger<ShoppingController> logger, ICategoryService categoryService, GlobalSettingService settings)
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
        [HttpGet]
        public IActionResult Index([FromQuery]string searchTerm, [FromQuery] long? CategoryId)
        {
            return View();
        }
    }
}
