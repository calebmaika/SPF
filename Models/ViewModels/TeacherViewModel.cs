using System.Collections.Generic;
using Alliance_Group_5_Project_Student_Performance_Tracker.Models;

namespace Alliance_Group_5_Project_Student_Performance_Tracker.ViewModels
{
    public class TeacherViewModel
    {
        public IEnumerable<Teacher> Teachers { get; set; } = new List<Teacher>();
        public List<Teacher> Teacher { get; set; } = new();
        public Teacher NewTeacher { get; set; } = new Teacher();
    }
}
