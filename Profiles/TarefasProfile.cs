using AutoMapper;
using TarefasApi.Dtos.Tarefas;
using TarefasApi.Models;

namespace TarefasApi.Profiles;

public class TarefasProfile : Profile
{
   public TarefasProfile()
    {
        CreateMap<AdicionarTarefaDto, Tarefas>();
        CreateMap<AtualizarTarefaDto, Tarefas>();
    }
}
