using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace SchoolCycode.Models.PostgreSQL
{
    public class SchoolCycodeContext : DbContext
    {
        public DbSet<Student> Students { get; set; }
        // public DbSet<Course> Courses { get; set; }
        // public DbSet<Grade> Grades { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            => optionsBuilder.UseNpgsql("Host=postgres;Database=Data;Username=postgres;Password=postgres");

        public SchoolCycodeContext(DbContextOptions<SchoolCycodeContext> options)
            : base(options)
        { }
    }

}