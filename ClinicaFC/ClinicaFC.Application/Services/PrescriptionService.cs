using ClinicaFC.Application.Dtos.DtoPrescription;
using ClinicaFC.Application.Interfaces;
using ClinicaFC.Domain.Entities;
using ClinicaFC.Domain.Repository;

namespace ClinicaFC.Application.Services
{
    public class PrescriptionService : GenericService<Prescription, CreatePrescriptionDto, ReadPrescriptionDto>, IPrescriptionServices
    {
        public PrescriptionService(IPrescriptionRepository repository) : base(repository)
        {
        }

        protected override Prescription ToEntity(CreatePrescriptionDto dto)
        {
            return new Prescription
            {
                ConsultationId = dto.ConsultationId,
                MedicationId = dto.MedicationId,
                Dosage = dto.Dosage,
                Frequency = dto.Frequency,
                Duration = dto.Duration
            };
        }

        protected override ReadPrescriptionDto ToReadDto(Prescription entity)
        {
            return new ReadPrescriptionDto
            {
                Id = entity.Id,
                ConsultationId = entity.ConsultationId,
                MedicationId = entity.MedicationId,
                Dosage = entity.Dosage,
                Frequency = entity.Frequency,
                Duration = entity.Duration
            };
        }
    }
}
