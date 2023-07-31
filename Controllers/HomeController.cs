using DoAN_k4.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace DoAN_k4.Controllers
{
    /*[Authorize]*/
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

    }
}
