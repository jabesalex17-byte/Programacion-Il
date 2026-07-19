using ClinicaFC.Application.Dtos.DtoAppointment;
using ClinicaFC.Application.Interfaces;
using ClinicaFC.Domain.Entities;
using ClinicaFC.Domain.Repository;

namespace ClinicaFC.Application.Services
{
    public class AppointmentService : GenericService<Appointment, CreateAppointmentDto, ReadAppointmentDto>, IAppointmentServices
    {
        public AppointmentService(IAppointmentRepository repository) : base(repository)
        {
        }

        protected override Appointment ToEntity(CreateAppointmentDto dto)
        {
            return new Appointment
            {
                PatientId = dto.PatientId,
                DoctorId = dto.DoctorId,
                Reason = dto.Reason
            };
        }

        protected override ReadAppointmentDto ToReadDto(Appointment entity)
        {
            return new ReadAppointmentDto
            {
                Id = entity.Id,
                PatientId = entity.PatientId,
                DoctorId = entity.DoctorId,
                Reason = entity.Reason,
                Status = entity.Status
            };
        }
    }
}
