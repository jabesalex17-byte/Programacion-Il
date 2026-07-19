using ClinicaFC.Application.Dtos.DtoRole;
using ClinicaFC.Application.Interfaces;
using ClinicaFC.Domain.Entities;
using ClinicaFC.Domain.Repository;

namespace ClinicaFC.Application.Services
{
    public class RoleService : GenericService<Role, CreateRoleDto, ReadRoleDto>, IRoleServices
    {
        public RoleService(IRoleRepository repository) : base(repository)
        {
        }

        protected override Role ToEntity(CreateRoleDto dto)
        {
            return new Role
            {
                Name = dto.Name,
                Description = dto.Description
            };
        }

        protected override ReadRoleDto ToReadDto(Role entity)
        {
            return new ReadRoleDto
            {
                Id = entity.Id,
                Name = entity.Name,
                Description = entity.Description
            };
        }
    }
}
