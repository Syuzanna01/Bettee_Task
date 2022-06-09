using System.ComponentModel.DataAnnotations.Schema;

namespace BeeteeManagement.Models
{
    public class HrDataRequest
    {
        public int Id { get; set; }
        public decimal Payroll { get; set; } = decimal.Zero;
        public string SocSecureNumber { get; set; } = string.Empty;
        public int EmployeeId { get; set; } = int.MinValue;
        public EmployeeRequest Employee { get; set; } 
        public decimal Salary { get; set; } = decimal.MaxValue;
    }
}
