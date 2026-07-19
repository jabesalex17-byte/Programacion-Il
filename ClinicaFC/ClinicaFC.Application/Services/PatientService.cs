using ClinicaFC.Application.Dtos.DtoPatient;
using ClinicaFC.Application.Interfaces;
using ClinicaFC.Domain.Entities;
using ClinicaFC.Domain.Repository;

namespace ClinicaFC.Application.Services
{
    public class PatientService : GenericService<Patient, CreatePatientDto, ReadPatientDto>, IPatientServices
    {
        public PatientService(IPatientRepository repository) : base(repository)
        {
        }

        protected override Patient ToEntity(CreatePatientDto dto)
        {
            return new Patient
            {
                FirstName = dto.FirstName,
                LastName = dto.LastName,
                Gender = dto.Gender,
                Phone = dto.Phone,
                Email = dto.Email,
                BloodType = dto.BloodType,
                Allergies = dto.Allergies,
                EmergencyPhone = dto.EmergencyPhone
            };
        }

        protected override ReadPatientDto ToReadDto(Patient entity)
        {
            return new ReadPatientDto
            {
                Id = entity.Id,
                FirstName = entity.FirstName,
                LastName = entity.LastName,
                Gender = entity.Gender,
                Phone = entity.Phone,
                Email = entity.Email,
                BloodType = entity.BloodType,
                Allergies = entity.Allergies,
                EmergencyPhone = entity.EmergencyPhone
            };
        }
    }
}
