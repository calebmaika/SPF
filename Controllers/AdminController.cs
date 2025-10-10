//dashboard and teacher management
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
                
                string teacherName = $"{vm.NewTeacher.FirstName} {vm.NewTeacher.LastName}";
                return RedirectToAction("Teachers", new { success = "added", name = teacherName });
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
                
                string teacherName = $"{teacher.FirstName} {teacher.LastName}";
                return RedirectToAction("Teachers", new { success = "updated", name = teacherName });
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
                string teacherName = $"{teacher.FirstName} {teacher.LastName}";
                _context.Teachers.Remove(teacher);
                _context.SaveChanges();
                
                return RedirectToAction("Teachers", new { success = "deleted", name = teacherName });
            }
            
            return RedirectToAction("Teachers", new { error = "Teacher not found" });
        }

        // GET: /admin/students
        public IActionResult Students()
        {
            var vm = new StudentViewModel
            {
                Students = _context.Students.ToList(),
                NewStudent = new Student()
            };
            return View(vm);
        }

        // POST: Add Student
        [HttpPost]
        public IActionResult AddStudent(StudentViewModel vm)
        {
            if (ModelState.IsValid && vm.NewStudent != null)
            {
                _context.Students.Add(vm.NewStudent);
                _context.SaveChanges();
                
                string studentName = $"{vm.NewStudent.FirstName} {vm.NewStudent.LastName}";
                return RedirectToAction("Students", new { success = "added", name = studentName });
            }

            // if invalid, reload page with existing students
            vm.Students = _context.Students.ToList();
            return View("Students", vm);
        }

        // GET: Edit Student (for modal)
        public IActionResult GetStudent(int id)
        {
            var student = _context.Students.Find(id);
            if (student == null)
            {
                return NotFound();
            }
            return Json(student);
        }

        // POST: Edit Student
        [HttpPost]
        public IActionResult EditStudent(Student student)
        {
            if (ModelState.IsValid)
            {
                _context.Students.Update(student);
                _context.SaveChanges();
                
                string studentName = $"{student.FirstName} {student.LastName}";
                return RedirectToAction("Students", new { success = "updated", name = studentName });
            }

            var vm = new StudentViewModel
            {
                Students = _context.Students.ToList(),
                NewStudent = student
            };
            return View("Students", vm);
        }

        // POST: Delete Student
        [HttpPost]
        public IActionResult DeleteStudent(int id)
        {
            var student = _context.Students.Find(id);
            if (student != null)
            {
                string studentName = $"{student.FirstName} {student.LastName}";
                _context.Students.Remove(student);
                _context.SaveChanges();
                
                return RedirectToAction("Students", new { success = "deleted", name = studentName });
            }
            
            return RedirectToAction("Students", new { error = "Student not found" });
        }
    }
}