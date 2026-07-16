using GimnasioFC.Domain.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GimnasioFC.Infrastructura.Models
{
    public class Member : BasePerson
    {
        public DateTime RegistrationDate { get; set; }

        public bool Active { get; set; }
    }
}
