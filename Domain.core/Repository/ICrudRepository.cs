using Domain.core.Entity.Generics;

namespace Domain.core.Repository
{
    public interface ICrudRepository<T,Y> where T : IAuto<T,Y> 
    {
        Task Criar(Y item);
        Task Atualizar(Y item);
        Task Excluir(int id);
        Task<IEnumerable<Y>> ObterTodos();
        Task<Y> ObterPorId(int? id);
    }
}
