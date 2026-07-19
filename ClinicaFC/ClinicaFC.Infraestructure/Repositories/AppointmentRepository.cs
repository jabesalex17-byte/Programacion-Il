using ClinicaFC.Domain.Entities;
using ClinicaFC.Domain.Repository;
using ClinicaFC.Infraestructure.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicaFC.Infraestructure.Repositories
{
    public class AppointmentRepository
        : GenericRepository<Appointment>, IAppointmentRepository
    {
        public AppointmentRepository(ClinicaFCDbContext db)
            : base(db)
        {
        }
    }
}
