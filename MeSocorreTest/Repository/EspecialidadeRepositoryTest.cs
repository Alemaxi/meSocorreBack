using Domain.core.DTO.Especialidade;
using Domain.core.Entity;
using MySqlInfrastructure;
using MySqlInfrastructure.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MeSocorreTest.Repository
{
    [Collection("MySql")]
    public class EspecialidadeRepositoryTest
    {
        MySqlContext _context;
        EspecialidadeRepository _repository;


        public EspecialidadeRepositoryTest(MySqlFixture fixture)
        {
            _context = fixture._context;
            _repository = fixture._especialidadeRepository;
        }

        [Fact]
        public void CriarEspecialidade()
        {
            var especialidade = new EspecialidadeDTO { Nome = "Cardiologia", Id = 0 };
            _repository.Criar(especialidade);

            var registro = _context.Especialidades.FirstOrDefault(x => x.Nome.Contains(especialidade.Nome));
            Assert.NotNull(registro);
        }

        [Fact]
        public void AtualizarEspecialidade()
        {
            var especialidade = new Especialidade { Nome = "Psicologia", Id=0 };
            var adicionado = _context.Add(especialidade).Entity;
            _context.SaveChanges();

            _context.ChangeTracker.Clear();
            
            var atualizado = new EspecialidadeDTO { Id = adicionado.Id, Nome = "Psicologia 2" };
            _repository.Atualizar(atualizado);

            especialidade = _context.Especialidades.FirstOrDefault(esp => esp.Nome.Contains(especialidade.Nome));
            Assert.NotEqual(especialidade.Nome, adicionado.Nome);
        }

        [Fact]
        public void ExcluirEspecialidade()
        {
            var especialidade = new Especialidade { Nome = "Neurologia", Id = 0 };
            especialidade = _context.Add(especialidade).Entity;
            _context.SaveChanges();

            _repository.Excluir(especialidade.Id);

            _context.ChangeTracker.Clear();

            var removed = _context.Especialidades.FirstOrDefault(x => x.Id == especialidade.Id);
            Assert.Null(removed);
        }

        [Fact]
        public async void ObterTodos()
        {
            var especialidade = new Especialidade { Nome = "Obstetria", Id = 0 };
            _context.Add(especialidade);
            var especialidade2 = new Especialidade { Nome = "Ortopedia", Id = 0 };
            _context.Add(especialidade2);
            _context.SaveChanges();

            var results = await _repository.ObterTodos();
            Assert.NotEmpty(results);
        }

        [Fact]
        public void ObterPorId()
        {
            var especialidade = new Especialidade { Nome = "angeologia", Id = 0 };
            especialidade = _context.Add(especialidade).Entity;
            _context.SaveChanges();

            var result = _repository.ObterPorId(especialidade.Id);
            Assert.NotNull(result);
        }
    }
}
