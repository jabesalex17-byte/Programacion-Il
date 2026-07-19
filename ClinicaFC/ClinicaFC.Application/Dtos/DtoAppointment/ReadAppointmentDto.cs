namespace ClinicaFC.Application.Dtos.DtoAppointment
{
    public class ReadAppointmentDto
    {
        public int Id { get; set; }
        public int PatientId { get; set; }
        public int DoctorId { get; set; }
        public string Reason { get; set; } = string.Empty;
        public string Status { get; set; } = string.Empty;
    }
}
