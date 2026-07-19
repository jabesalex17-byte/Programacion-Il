using ClinicaFC.Application.Dtos.DtoPatient;

namespace ClinicaFC.Application.Interfaces
{
    public interface IPatientServices
        : IGenericService<CreatePatientDto, ReadPatientDto>
    {
    }
}
