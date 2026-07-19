using ClinicaFC.Application.Dtos.DtoMedication;

namespace ClinicaFC.Application.Interfaces
{
    public interface IMedicationServices
        : IGenericService<CreateMedicationDto, ReadMedicationDto>
    {
    }
}
