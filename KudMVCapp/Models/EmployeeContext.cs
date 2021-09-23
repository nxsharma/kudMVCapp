using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace KudMVCapp.Models
{
    //model stuff to get data
    public class EmployeeContext : DbContext
    {
        
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Department> Departments { get; set; }
    }
}