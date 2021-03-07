using GL.FC.Services;
using GL.FC.Shared;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Security.Claims;
using System.Threading.Tasks;

namespace GL.FC.Web
{
    public class UserProfileController : Controller
    {
        private readonly IUserProfileService _userProfileService;

        public UserProfileController(IUserProfileService userProfileService)
        {
            _userProfileService = userProfileService;
        }

        [Authorize]
        public IActionResult Index()
        {
            var loggedInUserEmail = User.FindFirst(ClaimTypes.Email).Value;

            UserProfileModel user = _userProfileService.GetUserByEmail(loggedInUserEmail);

            return View(user);
        }


        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult UserLogin(string email)
        {
            var user = _userProfileService.GetUserByEmail(email);
            if (user != null)
            {
                var userClaims = new List<Claim>()
                {
                    new Claim("Id",user.Id.ToString()),
                    new Claim(ClaimTypes.Name, user.Name),
                    new Claim(ClaimTypes.Email, user.Email),
                    new Claim("Icon",user.ImagePath)
                 };

                var grandmaIdentity = new ClaimsIdentity(userClaims, CookieAuthenticationDefaults.AuthenticationScheme);

                var userPrincipal = new ClaimsPrincipal(new[] { grandmaIdentity });
                HttpContext.SignInAsync(userPrincipal);

                return RedirectToAction("Index", "Home");
            }

            return View(user);
        }

        [HttpPost]
        public async Task<IActionResult> Logout()
        {
            await HttpContext.SignOutAsync();
            return RedirectToAction("index");
        }
    }
}
