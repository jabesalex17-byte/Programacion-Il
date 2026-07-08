using GimnasioFC.Domain.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GimnasioFC.Domain.Entities
{
    public class Subscription : BaseEntity
    {

        public int MemberId { get; set; }

        public int MembershipId { get; set; }

        public DateTime FechaInicio { get; set; }

        public DateTime FechaFin { get; set; }

        public bool Activa { get; set; }
    }
}
