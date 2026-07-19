namespace ClinicaFC.Application.Dtos.DtoPatient
{
    public class CreatePatientDto
    {
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public string Gender { get; set; } = string.Empty;
        public string Phone { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string BloodType { get; set; } = string.Empty;
        public string? Allergies { get; set; }
        public string EmergencyPhone { get; set; } = string.Empty;
    }
}
