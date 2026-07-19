using ClinicaFC.Application.Dtos.DtoPrescription;

namespace ClinicaFC.Application.Interfaces
{
    public interface IPrescriptionServices
        : IGenericService<CreatePrescriptionDto, ReadPrescriptionDto>
    {
    }
}
