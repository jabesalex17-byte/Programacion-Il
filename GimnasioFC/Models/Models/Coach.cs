using GimnasioFC.Core;
 
namespace GimnasioFC.Models
{
    public class Coach : BasePerson
    {
        public int Id { get; set; }
        public DateTime HireDate { get; set; }
        public decimal Salary { get; set; }
        public bool IsActive { get; set; }
    }
}
