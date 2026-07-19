namespace ClinicaFC.Application.Dtos.DtoAppointment
{
    public class CreateAppointmentDto
    {
        public int PatientId { get; set; }
        public int DoctorId { get; set; }
        public string Reason { get; set; } = string.Empty;
    }
}
