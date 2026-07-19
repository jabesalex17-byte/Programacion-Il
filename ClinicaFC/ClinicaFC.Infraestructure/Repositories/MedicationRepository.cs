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
    public class MedicationRepository
        : GenericRepository<Medication>, IMedicationRepository
    {
        public MedicationRepository(ClinicaFCDbContext db)
            : base(db)
        {
        }
    }
}
