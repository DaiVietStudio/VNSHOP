using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VNSHOP.Web.Controllers
{
    public class LoginController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Login(HttpRequest request )
        {
            IFormCollection _form = request.Form;
            string username = _form["username"];
            string password = _form["password"];

            return RedirectToAction("Index", "Home");
        }
    }
}
