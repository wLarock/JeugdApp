using JeugdApp.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace JeugdApp.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Calender()
        {
            return View();
        }

        public IActionResult Activities()
        {
            return View();
        }

        public IActionResult Meetings()
        {
            return View();
        }

        public IActionResult YTT()
        {
            return View();
        }

        public IActionResult NoticeBoard()
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
