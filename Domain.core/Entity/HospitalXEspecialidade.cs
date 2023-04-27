using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.core.Entity
{
    public class HospitalXEspecialidade
    {
        public int HospitalXEspecialidadeId { get; set; }
        public int HospitalId { get; set; }
        public Hospital Hospital { get; set; }
        public int EspecialidadeId { get; set; }
        public Especialidade Especialidade { get; set; }
    }
}
