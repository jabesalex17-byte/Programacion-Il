namespace ClinicaFC.Application.Dtos.DtoConsultation
{
    public class CreateConsultationDto
    {
        public int AppointmentId { get; set; }
        public string Symptoms { get; set; } = string.Empty;
        public string DiagnosisSummary { get; set; } = string.Empty;
        public string Notes { get; set; } = string.Empty;
    }
}
