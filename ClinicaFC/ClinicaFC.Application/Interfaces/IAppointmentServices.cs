using ClinicaFC.Application.Dtos.DtoAppointment;

namespace ClinicaFC.Application.Interfaces
{
    public interface IAppointmentServices
        : IGenericService<CreateAppointmentDto, ReadAppointmentDto>
    {
    }
}
