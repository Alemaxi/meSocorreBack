using Microsoft.EntityFrameworkCore;
using MySqlInfrastructure;
using MySqlInfrastructure.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MeSocorreTest
{
    public class MySqlFixture: IDisposable
    {
        public MySqlContext _context;
        public EspecialidadeRepository _especialidadeRepository;
        public ExameRepostory _exameRepository;

        public MySqlFixture()
        {
            var options = new DbContextOptionsBuilder();
            options.UseInMemoryDatabase("Testing");

            _context = new MySqlContext(options.Options);

            _especialidadeRepository = new EspecialidadeRepository(_context);
            _exameRepository = new ExameRepostory(_context);
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }

    [CollectionDefinition("MySql")]
    public class FixtureCollection: ICollectionFixture<MySqlFixture>
    {

    }
}
