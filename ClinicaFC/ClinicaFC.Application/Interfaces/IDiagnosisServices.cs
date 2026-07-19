using ClinicaFC.Application.Dtos.DtoDiagnosis;

namespace ClinicaFC.Application.Interfaces
{
    public interface IDiagnosisServices
        : IGenericService<CreateDiagnosisDto, ReadDiagnosisDto>
    {
    }
}
