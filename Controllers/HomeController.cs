using DoAN_k4.Data;
using DoAN_k4.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace DoAN_k4.Controllers
{
    [Authorize]
    public class HomeController : Controller
    {

        private readonly ApplicationDBContext _dbContext;

        public HomeController(ApplicationDBContext dbContext)
        {
            _dbContext = dbContext;
        }
        public IActionResult Index()
        {
            var userId = User.FindFirst("UserId")?.Value;

            var user = _dbContext.users.Find(u => u.Id == userId).FirstOrDefault();

            /*ViewBag.Image = user.UserImage;*/
            TempData["Image"] = user.UserImage;
            return View(user);
        }

    }
}
