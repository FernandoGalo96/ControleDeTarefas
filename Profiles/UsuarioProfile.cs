using AutoMapper;
using TarefasApi.Dtos;
using TarefasApi.Models;

namespace TarefasApi.Profiles;

public class UsuarioProfile : Profile
{
    public UsuarioProfile() 
    {
        CreateMap<CreateUsuarioDto, Usuario>();
    } 
}
