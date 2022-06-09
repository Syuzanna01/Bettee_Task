using BeeteeManagement.Models;
using Microsoft.EntityFrameworkCore;

namespace BeeteeManagement.Data
{
    public class DataContext:DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) { }

        DbSet<EmployeeRequest> Employees { get; set; }
        DbSet<HrDataRequest> HrDatas { get; set; }
    }
}
