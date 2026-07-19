using ClinicaFC.Application.Dtos.DtoDiagnosis;
using ClinicaFC.Application.Interfaces;
using ClinicaFC.Domain.Entities;
using ClinicaFC.Domain.Repository;

namespace ClinicaFC.Application.Services
{
    public class DiagnosisService : GenericService<Diagnosis, CreateDiagnosisDto, ReadDiagnosisDto>, IDiagnosisServices
    {
        public DiagnosisService(IDiagnosisRepository repository) : base(repository)
        {
        }

        protected override Diagnosis ToEntity(CreateDiagnosisDto dto)
        {
            return new Diagnosis
            {
                ConsultationId = dto.ConsultationId,
                DiseaseName = dto.DiseaseName,
                Description = dto.Description,
                Severity = dto.Severity
            };
        }

        protected override ReadDiagnosisDto ToReadDto(Diagnosis entity)
        {
            return new ReadDiagnosisDto
            {
                Id = entity.Id,
                ConsultationId = entity.ConsultationId,
                DiseaseName = entity.DiseaseName,
                Description = entity.Description,
                Severity = entity.Severity
            };
        }
    }
}
