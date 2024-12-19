using AutoMapper;
using Microsoft.AspNetCore.Identity;
using TarefasApi.Dtos;
using TarefasApi.Models;
using TarefasApi.Services.Interface;

namespace TarefasApi.Services;

public class UsuarioService : IUsuarioService
{
     
     private readonly IMapper _mapper;
     private readonly UserManager<Usuario> _userManager;
     private readonly SignInManager<Usuario> _signInManager;
     private readonly TokenService _tokenService;

    public UsuarioService(IMapper mapper, UserManager<Usuario> userManager, SignInManager<Usuario> signInManager, TokenService tokenService)
    {
      
        _mapper = mapper;
        _userManager = userManager;
        _signInManager = signInManager;
        _tokenService = tokenService;
    }

    public async Task CadastroUsuario(CreateUsuarioDto createUsuarioDto)
    {
        Usuario usuario = _mapper.Map<Usuario>(createUsuarioDto);

        IdentityResult result = await _userManager.CreateAsync(usuario, createUsuarioDto.Password);

        if (!result.Succeeded) throw new ApplicationException("Falha ao cadastrar usuário!");
    }

    public async Task<string> LoginUsuario(LoginUsuarioDto loginUsuarioDto)
    {
        var result = await _signInManager.PasswordSignInAsync(loginUsuarioDto.Username, loginUsuarioDto.Password,false,false);

        if (!result.Succeeded) throw new ApplicationException("Falha ao fazer login");

        var usuario = _signInManager
              .UserManager
              .Users
              .FirstOrDefault(user => user.NormalizedUserName == loginUsuarioDto.Username.ToUpper());

        var token = _tokenService.GenerateToken(usuario);

        return token;

    }
}
