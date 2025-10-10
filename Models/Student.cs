using System.ComponentModel.DataAnnotations;

public class Student
{
    public int Id { get; set; }
    
    [Required]
    public string Username { get; set; } = string.Empty;
    
    [Required]
    public string Password { get; set; } = string.Empty;
    
    [Required]
    public string LastName { get; set; } = string.Empty;
    
    [Required]
    public string FirstName { get; set; } = string.Empty;
    
    [Required]
    [Range(1, 150)]
    public int Age { get; set; }
    
    [Required]
    public string GradeLevel { get; set; } = string.Empty;
}