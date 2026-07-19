using ClinicaFC.Application.Dtos.DtoSpecialty;

namespace ClinicaFC.Application.Interfaces
{
    public interface ISpecialtyServices
        : IGenericService<CreateSpecialtyDto, ReadSpecialtyDto>
    {
    }
}
