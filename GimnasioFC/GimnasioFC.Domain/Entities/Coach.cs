using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GimnasioFC.Infrastructura.Models
{
    public class Coach
    {
        public string Specialty { get; set; } = string.Empty;

        public decimal Salary { get; set; }

        public bool Active { get; set; }
    }
}
