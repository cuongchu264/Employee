using Microsoft.EntityFrameworkCore;

namespace Employee.Model
{
    public class EmployeeDbContext : DbContext
    {
        public EmployeeDbContext(DbContextOptions options)
            : base(options)
        { }
        public DbSet<employee> Employees { get; set; }
    }
}
