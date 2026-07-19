using MediCore.Core.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicaFC.Domain.Entities
{
    public class Appointment : BaseEntity
    {
        public int PatientId { get; set; }

        public int DoctorId { get; set; }

        public string Reason { get; set; } = string.Empty;

        public string Status { get; set; } = "Pending";

    }
}
