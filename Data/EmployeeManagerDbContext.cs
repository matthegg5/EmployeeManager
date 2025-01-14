using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using EmployeeManager.Data;

namespace EmployeeManager.Data
{
    public class EmployeeManagerDbContext : DbContext
    {
        public EmployeeManagerDbContext (DbContextOptions<EmployeeManagerDbContext> options)
            : base(options)
        {
        }

        public DbSet<EmployeeManager.Data.Employee> Employee { get; set; } = default!;
        public DbSet<EmployeeManager.Data.Department> Department { get; set; } = default!;

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Department>().HasData(
                new Department { Id = 1, Name = "Default Department" }
            );

            modelBuilder.Entity<Employee>().Property(e => e.DepartmentId).HasDefaultValue(1);
        }
    }
}
