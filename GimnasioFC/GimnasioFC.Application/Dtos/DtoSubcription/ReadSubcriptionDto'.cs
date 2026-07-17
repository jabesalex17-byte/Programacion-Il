using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GimnasioFC.Application.Dtos.DtoSubcription
{
    public class ReadSubcriptionDto
    {
        public DateTime FechaInicio { get; set; }

        public DateTime FechaFin { get; set; }

        public bool Activa { get; set; }
    }
}
