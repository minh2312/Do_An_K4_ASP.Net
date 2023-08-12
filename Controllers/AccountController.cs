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



        [HttpPost]
        public async Task<IActionResult> Login(string email, string password)
        {
            var acc = await _dbContext.users.Find(u => u.Email == email).FirstOrDefaultAsync();
            if (acc != null)
            {
                bool checkPass = BCrypt.Net.BCrypt.Verify(password, acc.Password);

                if (checkPass != false && acc.IsAdmin == true)
                {
                    var identity = new ClaimsIdentity(new[] { 
                        new Claim(ClaimTypes.Name, acc.Email),
                        new Claim("UserId", acc.Id), 
                        new Claim("FullName", acc.FirstName + " "+ acc.LastName),
                        new Claim("Email", acc.Email),
                        new Claim("ImageUser", acc.UserImage),
                    }, "DoAnKy4Security");
                    var pricipal = new ClaimsPrincipal(identity);
                    await HttpContext.SignInAsync("DoAnKy4Security", pricipal);
                    return RedirectToAction("Index", "Home");
                }
                else
                {
                    TempData["ErrorMessage"] = "Thông tin đăng nhập không hợp lệ!";
                    return View("Index");
                }
                
            }
            else
            {
                TempData["ErrorMessage"] = "Thông tin đăng nhập không hợp lệ!";
                return View("Index");

            }
        }

        public async Task<IActionResult> Logout()
        {
            await HttpContext.SignOutAsync("DoAnKy4Security");

            return RedirectToAction("Index", "Home");
        }



        public IActionResult Test()
        {
            return View();
        }



    }
}
