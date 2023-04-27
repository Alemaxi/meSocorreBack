using Domain.core.DTO.Especialidade;
using Domain.core.Entity;
using MySqlInfrastructure.Repository;
using MySqlInfrastructure;
using Domain.core.DTO.Exame;

namespace MeSocorreTest.Repository
{
    public class ExameRepositoryTest
    {
        MySqlContext _context;
        ExameRepostory _repository;


        public ExameRepositoryTest(MySqlFixture fixture)
        {
            _context = fixture._context;
            _repository = fixture._exameRepository;
        }

        [Fact]
        public void CriarEspecialidade()
        {
            var exame = new ExameDTO { Nome = "Cardiologia", Id = 0 };
            _repository.Criar(exame);

            var registro = _context.Exames.FirstOrDefault(x => x.Nome.Contains(especialidade.Nome));
            Assert.NotNull(registro);
        }

        [Fact]
        public void AtualizarEspecialidade()
        {
            var exame = new Exame { Nome = "Psicologia", Id = 0 };
            var adicionado = _context.Add(exame).Entity;
            _context.SaveChanges();

            _context.ChangeTracker.Clear();

            var atualizado = new ExameDTO { Id = adicionado.Id, Nome = "Psicologia 2" };
            _repository.Atualizar(atualizado);

            especialidade = _context.Exames.FirstOrDefault(esp => esp.Nome.Contains(especialidade.Nome));
            Assert.NotEqual(especialidade.Nome, adicionado.Nome);
        }

        [Fact]
        public void ExcluirEspecialidade()
        {
            var exame = new Exame { Nome = "Neurologia", Id = 0 };
            exame = _context.Add(exame).Entity;
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
