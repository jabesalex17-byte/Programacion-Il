using ClinicaFC.Application.Dtos.DtoMedication;
using ClinicaFC.Application.Interfaces;
using ClinicaFC.Domain.Entities;
using ClinicaFC.Domain.Repository;

namespace ClinicaFC.Application.Services
{
    public class MedicationService : GenericService<Medication, CreateMedicationDto, ReadMedicationDto>, IMedicationServices
    {
        public MedicationService(IMedicationRepository repository) : base(repository)
        {
        }

        protected override Medication ToEntity(CreateMedicationDto dto)
        {
            return new Medication
            {
                Name = dto.Name,
                Description = dto.Description,
                Manufacturer = dto.Manufacturer,
                Stock = dto.Stock
            };
        }

        protected override ReadMedicationDto ToReadDto(Medication entity)
        {
            return new ReadMedicationDto
            {
                Id = entity.Id,
                Name = entity.Name,
                Description = entity.Description,
                Manufacturer = entity.Manufacturer,
                Stock = entity.Stock
            };
        }
    }
}
