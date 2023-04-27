using Domain.core.DTO.Exame;
using Domain.core.Entity;
using Domain.core.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MySqlInfrastructure.Repository
{
    public class ExameRepostory: CrudRepository<Exame,ExameDTO>, IExameRepository
    {
        MySqlContext _context;

        public ExameRepostory(MySqlContext context): base(context)
        {
            _context = context;
        }
    }
}
