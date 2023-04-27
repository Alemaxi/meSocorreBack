using Domain.Administrador.Application;
using Domain.core.DTO.Especialidade;
using Domain.core.Entity;
using Microsoft.AspNetCore.Mvc;

namespace MeSocorreApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EspecialidadeController : ControllerBase
    {
        IEspecialidadeApplication _application;

        public EspecialidadeController(IEspecialidadeApplication application)
        {
            _application = application;
        }

        [HttpPost]
        public Task CriarEspecialidade(EspecialidadeDTO item)
        {
            _application.Criar(item);
            return Task.CompletedTask;
        }

        [HttpPut]
        public Task AtulizarEspecialidade(EspecialidadeDTO item)
        {
            _application.Atualizar(item); return Task.CompletedTask;
        }

        [HttpDelete]
        public Task DeletarEspecialidade(int id)
        {
            _application.Excluir(id);
            return Task.CompletedTask;
        }

        [HttpGet]
        public Task<IEnumerable<EspecialidadeDTO>> ObterTodos() 
        {
            var result = _application.ObterTodos();
            return result;
        }

        [HttpGet("{id}")]
        public Task<EspecialidadeDTO> ObterPorId(int id)
        {
            var result = _application.ObterPorId(id); return result;
        }

    }
}
