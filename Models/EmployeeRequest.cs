using BeeteeManagement.Helpers;

namespace BeeteeManagement.Models
{
    public class EmployeeRequest
    {
        public int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string IdentityNumber { get; set; }
        public DateTime BirthDate { get; set; }
        public GenderEnum Gender { get; set; }
        public string ContactNumber { get; set; }
        public string Email { get; set; }
        public ICollection<HrDataRequest> HrDatas {get;set;}
    }
}
