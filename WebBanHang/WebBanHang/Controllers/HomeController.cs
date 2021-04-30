using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebBanHang.Models;

namespace WebBanHang.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Trangchu()
        {
            return View();
        }

        public IActionResult Sanphammoi()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult KhuyenMai()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
        public IActionResult Danhmucsanpham()
        {
            ViewData["Message"] = "";

            return View();
        }
        public IActionResult Oder()
        {
            ViewData["Message"] = "";

            return View();
        }
        public IActionResult Login()
        {
            ViewData["Message"] = "";

            return View();
        }

    }
}
