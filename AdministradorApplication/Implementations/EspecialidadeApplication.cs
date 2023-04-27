using Domain.Administrador.Application;
using Domain.Administrador.Business;
using Domain.core.DTO.Especialidade;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdministradorApplication.Implementations
{
    public class EspecialidadeApplication: CrudApplication<EspecialidadeDTO, IEspecialidadeBusiness>, IEspecialidadeApplication
    {
        IEspecialidadeBusiness _business;

        public EspecialidadeApplication(IEspecialidadeBusiness business): base(business)
        {
            _business = business;
        }
    }
}
