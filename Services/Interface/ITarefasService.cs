using TarefasApi.Dtos.Tarefas;
using TarefasApi.Models;

namespace TarefasApi.Services.Interface;

public interface ITarefasService
{
    Task AdicionarTarefa(AdicionarTarefaDto tarefaDto, string usuarioId);

    Task<List<Tarefas>> RecuperarTodasTarefas();

    Task<List<Tarefas>> RecuperarTarefasPorUsuario(string usuarioId);

    Task AtualizarTarefa(int id, AtualizarTarefaDto tarefaDto, string usuarioId);

    Task DeletarTarefa(int id, string usuarioId);

    Task<Tarefas> BuscarTarefaEspecifica(int id);

    Task<List<Tarefas>> RecuperarTarefasPorStatus (string status);  
}
