using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class CompanyDbContext : DbContext
    { 
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
         => optionsBuilder.
         UseSqlServer("Server=. ; Database=CompanyDbEF ; Trusted_Connection=True ; Trust Server Certificate=True");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.
            Entity<Student>().
            HasMany<Course>().
            WithMany().
            UsingEntity<CourseStudent>().
            HasKey(c => new { c.StudentId, c.CourseId });



        modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());

    }


    public DbSet<Employee> Employees { get; set; }
    public DbSet<Department> Departments { get; set; }
    public DbSet<Student> Students { get; set; }
    public DbSet<Course> Courses { get; set; }
    public DbSet<CourseStudent> Studentscourse { get; set; }
}
}
