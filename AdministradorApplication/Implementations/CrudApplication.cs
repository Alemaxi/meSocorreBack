using Domain.Administrador.Application;
using Domain.Administrador.Business;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdministradorApplication.Implementations
{
    public class CrudApplication<T,Y>: ICrudApplication<T> where Y : ICrudBusiness<T>
    {
        Y _business;

        public CrudApplication(Y business)
        {
            _business = business;
        }

        public async Task Criar(T item)
        {
            await _business.Criar(item);
            return;
        }

        public async Task Atualizar(T item)
        {
            await _business.Atualizar(item);
            return;
        }

        public async Task Excluir(int id)
        {
            await _business.Excluir(id);
            return;
        }

        public Task<IEnumerable<T>> ObterTodos()
        {
            var result = _business.ObterTodos();
            return result;
        }

        public Task<T> ObterPorId(int? id)
        {
            var result = _business.ObterPorId(id);
            return result;
        }
    }
}
