using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using App.Services.ResponseProcessor;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using App.Models;
using App.Services.ApiRequest;
using App.Models.ViewModels;
using App.Services.ResponseProcessor.Interfaces;

namespace App.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IApiRequestService _reqService;
        private readonly IResponseProcessorService _respProc;

        public HomeController(ILogger<HomeController> logger, IApiRequestService reqService, IResponseProcessorService respProc)
        {
            _logger = logger;
            _reqService = reqService;
            _respProc = respProc;
        }

        public IActionResult Index()
        {
            var models = _reqService.Call().Result;

            MultipleArticleVM mAVM = _respProc.ProcessResponse(models);

            return View(mAVM);
        }

        public string Test()
        {
            var models = _reqService.Call().Result;
            return models.ToArray()[0].Type;
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
