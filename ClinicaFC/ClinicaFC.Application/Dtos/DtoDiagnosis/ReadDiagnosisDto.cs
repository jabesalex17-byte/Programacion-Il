namespace ClinicaFC.Application.Dtos.DtoDiagnosis
{
    public class ReadDiagnosisDto
    {
        public int Id { get; set; }
        public int ConsultationId { get; set; }
        public string DiseaseName { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public string Severity { get; set; } = string.Empty;
    }
}
