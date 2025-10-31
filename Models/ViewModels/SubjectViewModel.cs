using Alliance_Group_5_Project_Student_Performance_Tracker.Models;

namespace Alliance_Group_5_Project_Student_Performance_Tracker.ViewModels
{
    public class SubjectViewModel
    {
        public List<Subject> Subjects { get; set; } = new();
        public Subject NewSubject { get; set; } = new();
    }
}