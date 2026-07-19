using ClinicaFC.Application.Dtos.DtoSpecialty;
using ClinicaFC.Application.Interfaces;
using ClinicaFC.Domain.Entities;
using ClinicaFC.Domain.Repository;

namespace ClinicaFC.Application.Services
{
    public class SpecialtyService : GenericService<Specialty, CreateSpecialtyDto, ReadSpecialtyDto>, ISpecialtyServices
    {
        public SpecialtyService(ISpecialtyRepository repository) : base(repository)
        {
        }

        protected override Specialty ToEntity(CreateSpecialtyDto dto)
        {
            return new Specialty
            {
                Name = dto.Name,
                Description = dto.Description
            };
        }

        protected override ReadSpecialtyDto ToReadDto(Specialty entity)
        {
            return new ReadSpecialtyDto
            {
                Id = entity.Id,
                Name = entity.Name,
                Description = entity.Description
            };
        }
    }
}
