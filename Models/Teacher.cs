using System.ComponentModel.DataAnnotations;

namespace Alliance_Group_5_Project_Student_Performance_Tracker.Models
{
    public class Teacher
    {
        public int Id { get; set; }

        [Required, StringLength(50)]
        public string Username { get; set; } = string.Empty;

        [Required, StringLength(100)]
        public string Password { get; set; } = string.Empty;

        [Required, StringLength(50)]
        public string FirstName { get; set; } = string.Empty;

        [Required, StringLength(50)]
        public string LastName { get; set; } = string.Empty;

        [Range(18, 100)]
        public int Age { get; set; }

        //[Required, StringLength(100)]
        public Subject Subject { get; set; } 
    }
}
