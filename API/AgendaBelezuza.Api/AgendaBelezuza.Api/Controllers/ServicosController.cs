using AgendaBelezuza.Application.DTOs.Servicos;
using AgendaBelezuza.Application.Services.Servicos;
using Microsoft.AspNetCore.Mvc;

namespace AgendaBelezuza.Api.Controllers;

[ApiController]
[Route("api/[controller]")]
public class ServicosController : ControllerBase
{
    private readonly CriarServicoService _criarServicoService;

    public ServicosController(CriarServicoService criarServicoService)
    {
        _criarServicoService = criarServicoService;
    }

    [HttpPost]
    public async Task<IActionResult> Criar(CriarServicoRequest request)
    {
        var result = await _criarServicoService.ExecuteAsync(request);
        return CreatedAtAction(nameof(Criar), new { id = result.Id }, result);
    }
}
