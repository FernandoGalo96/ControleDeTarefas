using Microsoft.AspNetCore.Mvc;
using TarefasApi.Dtos;
using TarefasApi.Services.Interface;



namespace TarefasApi.Controllers;

[Route("[controller]")]
[ApiController]
public class UsuarioController : ControllerBase

{
      private readonly IUsuarioService _usuarioService;

    public UsuarioController(IUsuarioService usuarioService)
    {
        _usuarioService = usuarioService;
    }

   
    

  
    [HttpPost("cadastro")]
    public async Task<IActionResult> CriarUsuario([FromBody] CreateUsuarioDto usuarioDto)
    {
        if (!ModelState.IsValid) return BadRequest(ModelState);

        await _usuarioService.CadastroUsuario(usuarioDto);
        return Ok(new {Message = "Usuário cadastrado com sucesso!"});
    }

   
    [HttpPost("login")]
    public async Task<IActionResult> LoginUsuario ([FromBody] LoginUsuarioDto usuarioDto)
    {
        if (!ModelState.IsValid) return BadRequest(ModelState);

        var token = await _usuarioService.LoginUsuario(usuarioDto);
        return Ok(token);
    }

 
}
