using ContosoUniversity.Models;
using Microsoft.EntityFrameworkCore;

namespace ContosoUniversity.Data
{
    /*tinfo200:[2021-03-11-<tsepton>-dykstra1]- Creation of school context class with inheritance from the Dbcontext class
        */
    public class SchoolContext : DbContext
    {
        public SchoolContext(DbContextOptions<SchoolContext> options) : base(options)
        {
        }

        /*tinfo200:[2021-03-11-<tsepton>-dykstra1]- Telling the program that it must create a student context using the Courses, Enrollments, and Students properties
        */
        public DbSet<Course> Courses { get; set; }
        public DbSet<Enrollment> Enrollments { get; set; }
        public DbSet<Student> Students { get; set; }

        /*tinfo200:[2021-03-11-<tsepton>-dykstra1]- Method for instructing the program on how you want the program to name your tables
        */
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Course>().ToTable("Course");
            modelBuilder.Entity<Enrollment>().ToTable("Enrollment");
            modelBuilder.Entity<Student>().ToTable("Student");
        }
    }
}