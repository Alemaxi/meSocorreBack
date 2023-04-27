using Domain.Administrador.Business;
using Domain.core.Entity.Generics;
using Domain.core.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdministradorBusiness.Implementation
{
    public class CrudBusiness<T,Y,Z>: ICrudBusiness<Y> where Z : ICrudRepository<T,Y> where T : IAuto<T,Y>
    {
        Z _repository;

        public CrudBusiness(Z repository)
        {
            _repository = repository;
        }

        public async Task Criar(Y item)
        {
            await _repository.Criar(item);
            return;
        }

        public async Task Atualizar(Y item)
        {
            await _repository.Atualizar(item);
            return;
        }

        public async Task Excluir(int id)
        {
            await _repository.Excluir(id);
            return;
        }

        public async Task<IEnumerable<Y>> ObterTodos()
        {
            var result = await _repository.ObterTodos();
            return result;
        }

        public async Task<Y> ObterPorId(int? id)
        {
            var result = await _repository.ObterPorId(id);
            return result;
        }
    }
}
