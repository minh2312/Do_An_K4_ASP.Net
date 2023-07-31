using DoAN_k4.Data;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Mvc;
using MongoDB.Driver;
using System.Security.Claims;
using System.Threading.Tasks;
using System.Security.Cryptography;
using BCrypt;
using System.Security.Policy;
using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Authentication.Cookies;

namespace DoAN_k4.Controllers
{
    public class AccountController : Controller
    {
        private readonly ApplicationDBContext _dbContext;

        public AccountController(ApplicationDBContext dbContext)
        {
            _dbContext = dbContext;
        }
        public IActionResult Index()
        {
            return View();
        }


        /*[HttpPost]
        public async Task<IActionResult> Login(string email, string password)
        {
            var acc = await _dbContext.users.Find(u => u.Email == email).FirstOrDefaultAsync();
            if (acc != null)
            {
                bool checkPass = BCrypt.Net.BCrypt.Verify(password, acc.Password);
                ViewBag.emailDb = acc.Email;
                ViewBag.inputEmail = email;
                ViewBag.CheckEmail = acc.Email == email;
                ViewBag.Test = acc.Email != email && !checkPass;

                if (acc.Email != email && !checkPass )
                {
                    ViewBag.ErrorMessage = "Thông tin đăng nhập không hợp lệ!";
                    return View();
                }

                var identity = new ClaimsIdentity(new[] { new Claim(ClaimTypes.Name, acc.Email) }, "DoAnKy4");
                var pricipal = new ClaimsPrincipal(identity);
                HttpContext.SignInAsync("DoAnKy4", pricipal);
                return RedirectToAction(nameof(HomeController.Index), "Home");
            }
            

            return RedirectToAction("Index", "Home");
        }*/


        /*[HttpPost]
        public async Task<IActionResult> Login(string email, string password)
        {
            var acc = await _dbContext.users.Find(u => u.Email == email).FirstOrDefaultAsync();
            if (acc != null)
            {
                bool checkPass = BCrypt.Net.BCrypt.Verify(password, acc.Password);

                if (acc.Email != email && !checkPass && acc.IsAdmin == false)
                {
                    ViewBag.ErrorMessage = "Thông tin đăng nhập không hợp lệ!";
                    return View();
                }

                var identity = new ClaimsIdentity(new[] { new Claim(ClaimTypes.Name, acc.Email) }, "DoAnKy4Security");
                var pricipal = new ClaimsPrincipal(identity);
                await HttpContext.SignInAsync("DoAnKy4Security", pricipal);
                return RedirectToAction("Index", "Home");
            }


            return RedirectToAction("Index", "Home");
        }*/


        [HttpPost]
        [ActionName("Login")]
        public async Task<IActionResult> Login(string email, string password)
        {

            var user = await _dbContext.users.Find(u => u.Email == email).FirstOrDefaultAsync();

            if (user != null && BCrypt.Net.BCrypt.Verify(password,user.Password))
            {
                var claims = new List<Claim>
                {
                    new Claim(ClaimTypes.Name, user.Email),
                };

                var identity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);
                var principal = new ClaimsPrincipal(identity);

                await HttpContext.SignInAsync("DoAnKy4Security", principal);
                return RedirectToAction("Index","Home");
            }
            else
            {
                ModelState.AddModelError(string.Empty, "Invalid login attempt.");
                return View();
            }
        }


        public IActionResult Test()
        {
            return View();
        }



    }
}
