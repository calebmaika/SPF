using Microsoft.AspNetCore.Mvc;

namespace Alliance_Group_5_Project_Student_Performance_Tracker.Controllers
{
    [Route("admin")]
    public class AccountController : Controller
    {
        // GET: /admin/login
        [HttpGet("login")]
        public IActionResult Login()
        {
            return View();
        }

        // POST: /admin/login
        [HttpPost("login")]
        public IActionResult Login(string username, string password)
        {
            if (username == "admin" && password == "password123")
            {
                HttpContext.Session.SetString("IsAdmin", "true"); // ✅ set session
                return RedirectToAction("Dashboard", "Admin");
            }

            ViewBag.Error = "Invalid login credentials.";
            return View();
        }

        // GET: /admin/logout
        [HttpGet("logout")]
        public IActionResult Logout()
        {
            HttpContext.Session.Clear(); // ✅ clear session
            return RedirectToAction("Login");
        }
    }
}
