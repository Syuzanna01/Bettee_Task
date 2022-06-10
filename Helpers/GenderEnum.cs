using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;

namespace BeeteeManagement.Helpers
{
    [Keyless]
    [NotMapped]
    public class GenderEnum
    {
        public enum Gender
        {
            male = 1,
            female = 2,
            other = 3
        }
    }
}


