using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
  
namespace GimnasioFC.DTOs
{ 
    public class CoachDTO
    {
        [Required]
        [JsonIgnore]
        public int Id { get; set; }
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }
        [Required]
        public int Age { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        public string PhoneNumber { get; set; }
        [Required]
        public DateTime HireDate { get; set; }
        [Required]
        public decimal Salary { get; set; }
        [Required]
        public bool IsActive { get; set; }
    }
}
