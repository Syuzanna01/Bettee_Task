using BeeteeManagement.Helpers;

namespace BeeteeManagement.Models
{
    public class EmployeeRequest
    {
        public int ID { get; set; }
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public string IdentityNumber { get; set; } = string.Empty;
        public DateTime BirthDate { get; set; } = DateTime.MinValue;
        public GenderEnum Gender { get; set; } 
        public string ContactNumber { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public ICollection<HrDataRequest> HrDatas {get;set;} 
    }
}
