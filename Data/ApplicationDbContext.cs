using Microsoft.EntityFrameworkCore;
using StudentPerformanceAPI.Models;

namespace StudentPerformanceAPI.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Student> Students { get; set; }

    }
}
