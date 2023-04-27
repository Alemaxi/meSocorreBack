using Domain.Administrador.Business;
using Domain.core.DTO.Especialidade;
using Domain.core.Entity;
using Domain.core.Repository;

namespace AdministradorBusiness.Implementation
{
    public class EspecialidadeBusiness: CrudBusiness<Especialidade,EspecialidadeDTO, IEspecialidadeRepository>, IEspecialidadeBusiness
    {
        IEspecialidadeRepository _repository;

        public EspecialidadeBusiness(IEspecialidadeRepository repository):base(repository)
        {
            _repository = repository;
        }
    }
}
