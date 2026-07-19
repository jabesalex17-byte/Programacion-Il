using MediCore.Core.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicaFC.Domain.Entities
{
    public class Consultation : BaseEntity
    {
        public int AppointmentId { get; set; }

        public string Symptoms { get; set; } = string.Empty;

        public string DiagnosisSummary { get; set; } = string.Empty;

        public string Notes { get; set; } = string.Empty;
    }
}
