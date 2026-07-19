using ClinicaFC.Application.Dtos.DtoConsultation;
using ClinicaFC.Application.Interfaces;
using ClinicaFC.Domain.Entities;
using ClinicaFC.Domain.Repository;

namespace ClinicaFC.Application.Services
{
    public class ConsultationService : GenericService<Consultation, CreateConsultationDto, ReadConsultationDto>, IConsultationServices
    {
        public ConsultationService(IConsultationRepository repository) : base(repository)
        {
        }

        protected override Consultation ToEntity(CreateConsultationDto dto)
        {
            return new Consultation
            {
                AppointmentId = dto.AppointmentId,
                Symptoms = dto.Symptoms,
                DiagnosisSummary = dto.DiagnosisSummary,
                Notes = dto.Notes
            };
        }

        protected override ReadConsultationDto ToReadDto(Consultation entity)
        {
            return new ReadConsultationDto
            {
                Id = entity.Id,
                AppointmentId = entity.AppointmentId,
                Symptoms = entity.Symptoms,
                DiagnosisSummary = entity.DiagnosisSummary,
                Notes = entity.Notes
            };
        }
    }
}
