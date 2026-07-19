using MediCore.Core.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicaFC.Domain.Entities
{
    public class Patient : BasePerson
    {
        public string BloodType { get; set; } = string.Empty;

        public string? Allergies { get; set; }

        public string EmergencyPhone { get; set; } = string.Empty;

    }
}
