using Microsoft.EntityFrameworkCore;

namespace EmpAjaxJquery.Models
{
    public class EmployeeDbContext : DbContext
    {
        public EmployeeDbContext(DbContextOptions<EmployeeDbContext> options) : base(options)
        { }

        public DbSet<EmployeeModel> Emp1 { get; set; }
    }
}
