using System;
using digiestate.Web.Models;
using Microsoft.AspNetCore.Mvc;

namespace digiestate.Web.Controllers
{
    public class AccountsController : Controller
    {
        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Login(LoginModel model)
        {
            if(!ModelState.IsValid) return View();
            throw new NotImplementedException();
        }

        [HttpGet]
        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Register(RegisterModel model)
        {
            if(!ModelState.IsValid) return View();
            throw new NotImplementedException();
        }
    }
}