using cs_sstu_lab7.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace cs_sstu_lab7.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Invitation()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Invitation(PartyMember partyMember)
        {
            return View(partyMember);
        }

        public IActionResult Thanks()
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