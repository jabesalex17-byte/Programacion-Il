using ClinicaFC.Application.Dtos.DtoConsultation;

namespace ClinicaFC.Application.Interfaces
{
    public interface IConsultationServices
        : IGenericService<CreateConsultationDto, ReadConsultationDto>
    {
    }
}
