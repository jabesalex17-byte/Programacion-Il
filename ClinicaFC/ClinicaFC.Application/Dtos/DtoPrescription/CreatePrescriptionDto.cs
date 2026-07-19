namespace ClinicaFC.Application.Dtos.DtoPrescription
{
    public class CreatePrescriptionDto
    {
        public int ConsultationId { get; set; }
        public int MedicationId { get; set; }
        public string Dosage { get; set; } = string.Empty;
        public string Frequency { get; set; } = string.Empty;
        public string Duration { get; set; } = string.Empty;
    }
}
