using Domain.core.DTO.Exame;
using Domain.core.Entity.Generics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.core.Entity
{
    public class Exame: IAuto<Exame,ExameDTO>
    {
        public int Id { get; set; }
        public string? Nome { get; set; }

        public Exame AutoCriar(ExameDTO item)
        {
            throw new NotImplementedException();
        }

        public int? ObterId()
        {
            return Id;
        }

        public ExameDTO AutoTransformar()
        {
            throw new NotImplementedException();
        }
    }
}
