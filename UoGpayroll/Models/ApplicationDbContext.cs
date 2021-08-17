using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UoGpayroll.Models
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        public DbSet<Employee> Employee { get; set; }
        public DbSet<FinanceStaff> FinanceStaff { get; set; }
        public DbSet<Payroll>Payroll { get; set; }
        public DbSet<Tax> Tax { get; set; }
    }
}
