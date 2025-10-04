using System.Collections.Generic;
using Alliance_Group_5_Project_Student_Performance_Tracker.Models;

namespace Alliance_Group_5_Project_Student_Performance_Tracker.ViewModels
{
    public class StudentViewModel
    {
        public IEnumerable<Student> Students { get; set; } = new List<Student>();
        public Student NewStudent { get; set; } = new Student();
    }
}