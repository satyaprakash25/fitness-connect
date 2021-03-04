using GL.FC.Services;
using GL.FC.Shared;
using GL.FC.Web.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Diagnostics;
using System.Security.Claims;

namespace GL.FC.Web.Controllers
{
    [Authorize]
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IUserProfileService _userProfileService;

        public HomeController(ILogger<HomeController> logger, IUserProfileService userProfileService)
        {
            _logger = logger;
            _userProfileService = userProfileService;
        }

        public IActionResult Index()
        {
            var loggedInUserEmail = User.FindFirst(ClaimTypes.Email).Value;

            UserProfileModel user = _userProfileService.GetUserByEmail(loggedInUserEmail);
            return View(user);

        }

        [HttpPost]
        public IActionResult UpdateUserHealthInformation()
        {
            return RedirectToAction("Index");
        }

        public IActionResult Profile()
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
