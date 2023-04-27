using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.core.Entity
{
    public class HospitalXExame
    {
        public int HospitalXExameId { get; set; }
        public int HospitalId { get; set; }
        public Hospital Hospital { get; set; }
        public int ExameId { get; set; }
        public Exame Exame { get; set; }
    }
}
