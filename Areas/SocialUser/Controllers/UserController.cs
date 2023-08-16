using DoAN_k4.Data;
using DoAN_k4.Models;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MongoDB.Driver;
using System;
using System.Net.Http;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace DoAN_k4.Areas.SocialUser.Controllers
{
    [Area("SocialUser")]
    public class UserController : Controller
    {
        private readonly ApplicationDBContext _dbContext;
        public UserController(ApplicationDBContext dbContext)
        {
            _dbContext = dbContext;
        }

        public IActionResult Index()
        {
            if (User.Identity.IsAuthenticated)
            {
                return RedirectToAction("Index", "Home");
            }
            return View();
        }

        public async Task<IActionResult> Login(string email, string password)
        {
            var acc = await _dbContext.users.Find(u => u.Email == email && u.Status).FirstOrDefaultAsync();
            if (acc != null)
            {
                bool checkPass = BCrypt.Net.BCrypt.Verify(password, acc.Password);
                if (checkPass != false)
                {
                    HttpContext.Session.SetString("UserLogin", acc.Id);
                    HttpContext.Session.SetString("Email", acc.Email);
                    HttpContext.Session.SetString("UserName", acc.FirstName + " "+acc.LastName);
                    HttpContext.Session.SetString("Image", acc.UserImage);
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

        [HttpPost]
        public async Task<IActionResult> RegisterUser(string lname, string fname, string email, string password, string phone)
        {
            if (string.IsNullOrEmpty(lname) || string.IsNullOrEmpty(fname) || string.IsNullOrEmpty(email) || string.IsNullOrEmpty(password) || string.IsNullOrEmpty(phone))
            {
                TempData["ErrorMessage"] = "Đăng Ký Thất Bại";
                return View("Index");
            }

            string pass = BCrypt.Net.BCrypt.HashPassword(password);
            var newUser = new User
            {
                FirstName = fname,
                LastName = lname,
                Email = email,
                Phone = phone,
                Password = pass,
                CreatedAt = DateTime.UtcNow,
                UpdatedAt = DateTime.UtcNow,
                IsAdmin = false,
                Status = true
            };
            await _dbContext.users.InsertOneAsync(newUser);
            TempData["SuccessMessage"] = "Đăng Ký Thành Công";
            return View("Index");
        }

        public async Task<IActionResult> Test()
        {
            return View();
        }
        public async Task<IActionResult> Logout()
        {
            await HttpContext.SignOutAsync("DoAnKy4Security");

            return RedirectToAction("Index", "User");
        }
    }
}
