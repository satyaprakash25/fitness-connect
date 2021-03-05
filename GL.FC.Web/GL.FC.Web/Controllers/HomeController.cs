using GL.FC.Services;
using GL.FC.Shared;
using GL.FC.Web.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Diagnostics;
using System.Security.Claims;

namespace GL.FC.Web.Controllers
{
    [Authorize]
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IUserProfileService _userProfileService;
        private readonly IUserHealthService _userHealthService;

        public HomeController(ILogger<HomeController> logger, IUserProfileService userProfileService,
            IUserHealthService userHealthService)
        {
            _logger = logger;
            _userProfileService = userProfileService;
            _userHealthService = userHealthService;
        }

        public IActionResult Index()
        {
            var loggedInUserEmail = User.FindFirst(ClaimTypes.Email).Value;

            UserProfileModel user = _userProfileService.GetUserByEmail(loggedInUserEmail);
            return View(user);

        }

        [HttpPost]
        public IActionResult SaveUserHealthInformation(UserHealthModel userHealthModel)
        {
            userHealthModel.UserId = Convert.ToInt32(User.FindFirst("Id").Value);

            userHealthModel.CreationDate = DateTime.Now;
            userHealthModel.ModificationDate = DateTime.Now;

            _userHealthService.Add(userHealthModel);
            return RedirectToAction("index", "home");
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
