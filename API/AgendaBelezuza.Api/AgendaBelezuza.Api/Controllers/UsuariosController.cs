using AgendaBelezuza.Application.DTOs.Usuarios;
using AgendaBelezuza.Application.Services.Usuarios;
using Microsoft.AspNetCore.Mvc;

namespace AgendaBelezuza.Api.Controllers;

[ApiController]
[Route("api/[controller]")]
public class UsuariosController : ControllerBase
{
    private readonly CriarUsuarioService _criarUsuarioService;

    public UsuariosController(CriarUsuarioService criarUsuarioService)
    {
        _criarUsuarioService = criarUsuarioService;
    }

    [HttpPost]
    public async Task<IActionResult> Criar(CriarUsuarioRequest request)
    {
        var result = await _criarUsuarioService.ExecuteAsync(request);
        return CreatedAtAction(nameof(Criar), new { id = result.Id }, result);
    }
}
