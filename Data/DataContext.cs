using BeeteeManagement.Models;

namespace BeeteeManagement.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) { }

        public DbSet<EmployeeRequest> Employeess { get; set; }
        public DbSet<HrDataRequest> HrDatas { get; set; }
    }
}
