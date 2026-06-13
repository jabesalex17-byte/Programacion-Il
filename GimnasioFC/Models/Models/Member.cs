using GimnasioFC.Core;
namespace GimnasioFC.Models
{ 
    public class Member : BasePerson
    {
        public int Id { get; set; }
        public DateTime EnrollmentDate { get; set; }
        public bool IsActive { get; set; }

    }
}
