using System;
using JenkinsIntegration.Services;
using Microsoft.AspNetCore.Mvc;

namespace JenkinsIntegration.Controllers
{
    public class HomeController : Controller
    {

        private readonly IDataService _dataService;

        public HomeController(IDataService dataService)
        {
            _dataService = dataService;
        }

        public IActionResult Index()
        {
            ViewData["HostName"] = _dataService.GetHost();
            return View();
        }
    }
}
