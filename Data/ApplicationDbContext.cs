using Microsoft.EntityFrameworkCore;
using Alliance_Group_5_Project_Student_Performance_Tracker.Models;

namespace Alliance_Group_5_Project_Student_Performance_Tracker.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Teacher> Teachers { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<Subject> Subjects { get; set; }
        

    }
}

