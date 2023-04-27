using Domain.core.DTO.Especialidade;
using Domain.core.Entity.Generics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.core.Entity
{
    public class Especialidade: IAuto<Especialidade, EspecialidadeDTO>
    {
        public int Id { get; set; }
        public string? Nome { get; set; }

        public Especialidade AutoCriar(EspecialidadeDTO item)
        {
            return new Especialidade { Id = (int)item.Id, Nome= item.Nome };
        }

        public int? ObterId()
        {
            return Id;
        }

        public EspecialidadeDTO AutoTransformar()
        {
            return new EspecialidadeDTO { Id = Id, Nome = Nome };
        }
    }
}
