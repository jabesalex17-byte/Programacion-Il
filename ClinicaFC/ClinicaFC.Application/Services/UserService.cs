using ClinicaFC.Application.Dtos.DtoUser;
using ClinicaFC.Application.Interfaces;
using ClinicaFC.Domain.Entities;
using ClinicaFC.Domain.Repository;

namespace ClinicaFC.Application.Services
{
    public class UserService : GenericService<User, CreateUserDto, ReadUserDto>, IUserServices
    {
        public UserService(IUserRepository repository) : base(repository)
        {
        }

        protected override User ToEntity(CreateUserDto dto)
        {
            return new User
            {
                FirstName = dto.FirstName,
                LastName = dto.LastName,
                Gender = dto.Gender,
                Phone = dto.Phone,
                Email = dto.Email,
                Username = dto.Username,
                PasswordHash = dto.Password,
                IsActive = dto.IsActive,
                RoleId = dto.RoleId
            };
        }

        protected override ReadUserDto ToReadDto(User entity)
        {
            return new ReadUserDto
            {
                Id = entity.Id,
                FirstName = entity.FirstName,
                LastName = entity.LastName,
                Gender = entity.Gender,
                Phone = entity.Phone,
                Email = entity.Email,
                Username = entity.Username,
                IsActive = entity.IsActive,
                RoleId = entity.RoleId
            };
        }
    }
}
