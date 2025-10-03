using Microsoft.AspNetCore.Mvc;
using Alliance_Group_5_Project_Student_Performance_Tracker.Data;
using Alliance_Group_5_Project_Student_Performance_Tracker.Models;
using Alliance_Group_5_Project_Student_Performance_Tracker.ViewModels;

namespace Alliance_Group_5_Project_Student_Performance_Tracker.Controllers
{
    public class AdminController : Controller
    {
        private readonly ApplicationDbContext _context;

        public AdminController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: /admin/dashboard
        public IActionResult Dashboard()
        {
            return View();
        }

        // GET: /admin/teachers
        public IActionResult Teachers()
        {
            var vm = new TeacherViewModel
            {
                Teachers = _context.Teachers.ToList(),
                NewTeacher = new Teacher()
            };
            return View(vm);
        }

        // POST: Add Teacher
        [HttpPost]
        public IActionResult AddTeacher(TeacherViewModel vm)
        {
            if (ModelState.IsValid && vm.NewTeacher != null)
            {
                _context.Teachers.Add(vm.NewTeacher);
                _context.SaveChanges();
                return RedirectToAction("Teachers");
            }

            // if invalid, reload page with existing teachers
            vm.Teachers = _context.Teachers.ToList();
            return View("Teachers", vm);
        }

        // GET: Edit Teacher (for modal)
        public IActionResult GetTeacher(int id)
        {
            var teacher = _context.Teachers.Find(id);
            if (teacher == null)
            {
                return NotFound();
            }
            return Json(teacher);
        }

        // POST: Edit Teacher
        [HttpPost]
        public IActionResult EditTeacher(Teacher teacher)
        {
            if (ModelState.IsValid)
            {
                _context.Teachers.Update(teacher);
                _context.SaveChanges();
                return RedirectToAction("Teachers");
            }

            var vm = new TeacherViewModel
            {
                Teachers = _context.Teachers.ToList(),
                NewTeacher = teacher
            };
            return View("Teachers", vm);
        }

        // POST: Delete Teacher
        [HttpPost]
        public IActionResult DeleteTeacher(int id)
        {
            var teacher = _context.Teachers.Find(id);
            if (teacher != null)
            {
                _context.Teachers.Remove(teacher);
                _context.SaveChanges();
            }
            return RedirectToAction("Teachers");
        }
    }
}