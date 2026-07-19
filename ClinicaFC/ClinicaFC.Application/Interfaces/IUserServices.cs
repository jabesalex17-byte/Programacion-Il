using ClinicaFC.Application.Dtos.DtoUser;

namespace ClinicaFC.Application.Interfaces
{
    public interface IUserServices
        : IGenericService<CreateUserDto, ReadUserDto>
    {
    }
}
