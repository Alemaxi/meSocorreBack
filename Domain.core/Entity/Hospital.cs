using Domain.core.Entity.Generics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.core.Entity
{
    public class Hospital
    {
        public int HospitalId { get; set; }
        public string? Nome { get; set; }
        public string? Logradouro { get; set; }
        public string? Bairro { get; set; }
        public string? Cidade { get; set; }
        public int? Numero { get; set; }
        public string? Cep { get; set; }
        public string? Foto { get; set; }
        public IEnumerable<HospitalXEspecialidade> HospitaisXEspecialidades { get; set; }
        public IEnumerable<HospitalXExame> HospitaisXExames { get; set; }
    }
}
