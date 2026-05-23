
using Microsoft.AspNetCore.Mvc;
using NdpPortfolio.Core.Interfaces.Services;
using NdpPortfolio.UI.Models;
using System.Diagnostics;


namespace NdpPortfolio.UI.Controllers
{
    public class HomeController: Controller
    {
        IProjectService _projectService;
        ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger, IProjectService projectService)
        {
            _logger = logger;
            _projectService = projectService;
        }

        public IActionResult Index()
        {
            var projects = _projectService.GetAllProjects();
            return View(projects);
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
