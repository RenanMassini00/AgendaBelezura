using AgendaBelezuza.Application.DTOs.Profissionais;
using AgendaBelezuza.Application.Services.Profissionais;
using Microsoft.AspNetCore.Mvc;

namespace AgendaBelezuza.Api.Controllers;

[ApiController]
[Route("api/[controller]")]
public class ProfissionaisController : ControllerBase
{
    private readonly CriarProfissionalService _criarProfissionalService;

    public ProfissionaisController(CriarProfissionalService criarProfissionalService)
    {
        _criarProfissionalService = criarProfissionalService;
    }

    [HttpPost]
    public async Task<IActionResult> Criar(CriarProfissionalRequest request)
    {
        var result = await _criarProfissionalService.ExecuteAsync(request);
        return CreatedAtAction(nameof(Criar), new { id = result.Id }, result);
    }
}
