using StudentPerformanceAPI.Models; 
using Microsoft.EntityFrameworkCore;

namespace StudentPerformanceAPI.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }
        public DbSet<Student> Students { get; set; } // DbSet for Student model
    } 
    

    }

