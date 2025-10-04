using System.ComponentModel.DataAnnotations;

namespace Alliance_Group_5_Project_Student_Performance_Tracker.Models
{
    public class Student
    {
        public int Id { get; set; }
        
        [Required]
        public string Username { get; set; }
        
        [Required]
        public string Password { get; set; }
        
        [Required]
        public string LastName { get; set; }
        
        [Required]
        public string FirstName { get; set; }
        
        [Required]
        [Range(1, 150)]
        public int Age { get; set; }
        
        [Required]
        public string GradeLevel { get; set; }
    }
}