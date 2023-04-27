using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Administrador.Business
{
    public interface ICrudBusiness<T>
    {
        Task Criar(T item);
        Task Atualizar(T item);
        Task Excluir(int id);
        Task<IEnumerable<T>> ObterTodos();
        Task<T> ObterPorId(int? id);
    }
}
