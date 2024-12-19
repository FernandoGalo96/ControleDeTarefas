using TarefasApi.Dtos;

namespace TarefasApi.Services.Interface;

public interface IUsuarioService
{

     Task CadastroUsuario(CreateUsuarioDto createUsuarioDto);

     Task<string> LoginUsuario (LoginUsuarioDto loginUsuarioDto);
}
