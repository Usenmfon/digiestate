using Microsoft.AspNetCore.Mvc;

namespace digiestate.Web.Controllers
{
    public class AccountsController : Controller
    {
        public IActionResult Login()
        {
            return View();
        }
        public IActionResult Register()
        {
            return View();
        }
    }
}