namespace ClinicaFC.Application.Dtos.DtoDiagnosis
{
    public class CreateDiagnosisDto
    {
        public int ConsultationId { get; set; }
        public string DiseaseName { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public string Severity { get; set; } = string.Empty;
    }
}
