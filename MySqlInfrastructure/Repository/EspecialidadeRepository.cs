using Domain.core.DTO.Especialidade;
using Domain.core.Entity;
using Domain.core.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MySqlInfrastructure.Repository
{
    public class EspecialidadeRepository: CrudRepository<Especialidade,EspecialidadeDTO>, IEspecialidadeRepository
    {
        MySqlContext _context;

        public EspecialidadeRepository(MySqlContext context): base(context)
        {
            _context = context;
        }
    }
}
