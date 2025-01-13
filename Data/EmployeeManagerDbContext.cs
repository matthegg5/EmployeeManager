using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace EmployeeManager.Data
{
    public class EmployeeManagerDbContext : DbContext
    {
        public EmployeeManagerDbContext (DbContextOptions<EmployeeManagerDbContext> options)
            : base(options)
        {
        }

        public DbSet<EmployeeManager.Data.Employee> Employee { get; set; } = default!;
    }
}
