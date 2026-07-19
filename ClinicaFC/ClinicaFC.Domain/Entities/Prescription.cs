using MediCore.Core.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicaFC.Domain.Entities
{
    public class Prescription : BaseEntity
    {
        public int ConsultationId { get; set; }

        public int MedicationId { get; set; }

        public string Dosage { get; set; } = string.Empty;

        public string Frequency { get; set; } = string.Empty;

        public string Duration { get; set; } = string.Empty;

    }
}
