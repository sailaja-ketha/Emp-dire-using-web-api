using Microsoft.EntityFrameworkCore;

namespace EmployeeDirectory.Models
{
    public class ApplicationDbContext: DbContext
    {
        public  ApplicationDbContext(DbContextOptions<ApplicationDbContext> options): base(options) { }
        public  DbSet<Employee> Employees { get; set; }
        public DbSet<JobTitle> JobTitles { get; set; }
        public  DbSet<Office> offices { get; set; }
        public DbSet<Department> Departments { get; set; }



    }
}
