using EmployeeManagement.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmpoyeeDAL.Models
{
    public class EmployeeDBContext: DbContext
    {

        public EmployeeDBContext(DbContextOptions<EmployeeDBContext> contextOptions) : base (contextOptions)
        {

        }

        public DbSet<Employee> Employees{ get; set; }
    }
}
