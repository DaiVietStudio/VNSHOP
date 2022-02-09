using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using VNSHOP.Data.Applications.Services;
namespace VNSHOP.Web.Controllers
{
    public class LoginController : Controller
    {
        private LoginService loginService = new LoginService();
        public IActionResult Index()
        {
            // Check login ready

            return View();
        }

        [HttpPost]
        public IActionResult Login()
        {
            
            string username = HttpContext.Request.Form["username"];
            string password = HttpContext.Request.Form["password"];
            Dictionary<string, dynamic> result = loginService.Login(username, password);
            if (result["status"] == true)
            {
                return RedirectToAction("Index", "Home");
            }
            else
            {
                ViewBag.Error = result["error"];
                return RedirectToAction("Index", "Login");

            }

        }
    }
}
