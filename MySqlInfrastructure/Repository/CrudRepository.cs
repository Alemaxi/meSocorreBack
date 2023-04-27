using Domain.core.Entity.Generics;
using Domain.core.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MySqlInfrastructure.Repository
{
    public class CrudRepository<T,Y> : ICrudRepository<T,Y> where T : class, IAuto<T, Y>, new()
    {
        MySqlContext _context;

        public CrudRepository(MySqlContext context)
        {
            _context = context;
        }

        public Task Criar(Y item)
        {
            _context.Add(new T().AutoCriar(item));
            _context.SaveChanges();

            return Task.CompletedTask;
        }

        public Task Atualizar(Y item)
        {
            _context.Update(new T().AutoCriar(item));
            _context.SaveChanges();

            return Task.CompletedTask;
        }

        public async Task Excluir(int id)
        {
            var excluir = _context.Set<T>().FirstOrDefault(x => x.Id == id);
            _context.Remove(excluir);
            _context.SaveChanges();

            return;
        }

        public async Task<IEnumerable<Y>> ObterTodos()
        {
            var result = _context.Set<T>().Select(x => x.AutoTransformar()).AsEnumerable();

            return result;
        }

        public Task<Y> ObterPorId(int? id)
        {
            var result = _context.Set<T>().FirstOrDefault(x => x.Id == id);

            return Task.FromResult(result.AutoTransformar());
        }
    }
}