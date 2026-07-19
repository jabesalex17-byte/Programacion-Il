using ClinicaFC.Application.Dtos.DtoDoctor;
using ClinicaFC.Application.Interfaces;
using ClinicaFC.Domain.Entities;
using ClinicaFC.Domain.Repository;

namespace ClinicaFC.Application.Services
{
    public class DoctorService : GenericService<Doctor, CreateDoctorDto, ReadDoctorDto>, IDoctorServices
    {
        public DoctorService(IDoctorRepository repository) : base(repository)
        {
        }

        protected override Doctor ToEntity(CreateDoctorDto dto)
        {
            return new Doctor
            {
                FirstName = dto.FirstName,
                LastName = dto.LastName,
                Gender = dto.Gender,
                Phone = dto.Phone,
                Email = dto.Email,
                LicenseNumber = dto.LicenseNumber,
                SpecialtyId = dto.SpecialtyId
            };
        }

        protected override ReadDoctorDto ToReadDto(Doctor entity)
        {
            return new ReadDoctorDto
            {
                Id = entity.Id,
                FirstName = entity.FirstName,
                LastName = entity.LastName,
                Gender = entity.Gender,
                Phone = entity.Phone,
                Email = entity.Email,
                LicenseNumber = entity.LicenseNumber,
                SpecialtyId = entity.SpecialtyId
            };
        }
    }
}
