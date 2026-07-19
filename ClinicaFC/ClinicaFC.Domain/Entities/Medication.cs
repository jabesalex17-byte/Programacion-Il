using MediCore.Core.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicaFC.Domain.Entities
{
    public class Medication : BaseEntity
    {
        public string Name { get; set; } = string.Empty;

        public string Description { get; set; } = string.Empty;

        public string Manufacturer { get; set; } = string.Empty;

        public int Stock { get; set; }
    }
}
