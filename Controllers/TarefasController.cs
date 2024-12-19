using System.Security.Claims;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using TarefasApi.Dtos.Tarefas;
using TarefasApi.Services.Interface;



namespace TarefasApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TarefasController : ControllerBase
    {
        private readonly ITarefasService _tarefasService;

        public TarefasController(ITarefasService tarefasService)
        {
            _tarefasService = tarefasService;
        }

        [Authorize]
        [HttpGet]
        public async Task<IActionResult> GetTarefas()
        {
            var usuarioId = User.FindFirstValue(ClaimTypes.NameIdentifier);
            var tarefas = await _tarefasService.RecuperarTarefasPorUsuario(usuarioId);
            return Ok(tarefas);
        }

        [Authorize]
        [HttpPost]
        public async Task<IActionResult> AdicionarTarefa([FromBody] AdicionarTarefaDto dto)
        {
            var usuarioId = User.FindFirstValue(ClaimTypes.NameIdentifier);
            await _tarefasService.AdicionarTarefa(dto, usuarioId);
            return CreatedAtAction(nameof(GetTarefas), null);

        }


        [Authorize]
        [HttpPut("{id}")]
        public async Task<IActionResult> AtualizarTarefa(int id, [FromBody] AtualizarTarefaDto atualizarTarefaDto)
        {
            var usuarioId = User.FindFirstValue(ClaimTypes.NameIdentifier);
            await _tarefasService.AtualizarTarefa(id, atualizarTarefaDto, usuarioId);
            return NoContent();

        }


        [Authorize]
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeletarTarefa(int id)
        {
            var usuarioId = User.FindFirstValue(ClaimTypes.NameIdentifier);
            await _tarefasService.DeletarTarefa(id, usuarioId);
            return NoContent();
        }
    }
}
