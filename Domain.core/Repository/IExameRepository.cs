using Domain.core.DTO.Exame;
using Domain.core.Entity;

namespace Domain.core.Repository
{
    public interface IExameRepository: ICrudRepository<Exame,ExameDTO>
    {
    }
}
