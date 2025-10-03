using Microsoft.AspNetCore.Mvc;

namespace Alliance_Group_5_Project_Student_Performance_Tracker.Controllers
{
    [Route("admin")]
    public class AdminController : Controller
    {
        // GET: /admin/dashboard
        [HttpGet("dashboard")]
        public IActionResult Dashboard()
        {
            // check if logged in
            if (HttpContext.Session.GetString("IsAdmin") == "true")
            {
                return View();
            }

            return RedirectToAction("Login", "Account");
        }
    }
}
