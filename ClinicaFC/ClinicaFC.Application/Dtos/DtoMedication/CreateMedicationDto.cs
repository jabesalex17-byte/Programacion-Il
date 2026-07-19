namespace ClinicaFC.Application.Dtos.DtoMedication
{
    public class CreateMedicationDto
    {
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public string Manufacturer { get; set; } = string.Empty;
        public int Stock { get; set; }
    }
}
