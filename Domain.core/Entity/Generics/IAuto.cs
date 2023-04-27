using Domain.core.DTO.Especialidade;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.core.Entity.Generics
{
    public interface IAuto<T,Y>
    {
        public int Id { get; set; }
        T AutoCriar(Y item);
        int? ObterId();
        Y AutoTransformar();
    }
}
