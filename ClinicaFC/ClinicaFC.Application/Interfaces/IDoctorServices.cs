using ClinicaFC.Application.Dtos.DtoDoctor;

namespace ClinicaFC.Application.Interfaces
{
    public interface IDoctorServices
        : IGenericService<CreateDoctorDto, ReadDoctorDto>
    {
    }
}
