using System.ComponentModel.DataAnnotations.Schema;

namespace BeeteeManagement.Models
{
    public class HrDataRequest
    {
        public int Id { get; set; }
        public decimal Payroll { get; set; } 
        public string SocSecureNumber { get; set; }
        public int EmployeeId { get; set; }
        public EmployeeRequest? Employee { get; set; } 
        public decimal Salary { get; set; } 
    }
}
