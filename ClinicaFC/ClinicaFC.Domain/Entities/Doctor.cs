using MediCore.Core.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicaFC.Domain.Entities
{
    public class Doctor : BasePerson
    {
        public string LicenseNumber { get; set; } = string.Empty;

        public int SpecialtyId { get; set; }
    }
}
