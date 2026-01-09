using AgendaBelezuza.Application.DTOs.Agendamentos;
using AgendaBelezuza.Application.Services.Agendamentos;
using Microsoft.AspNetCore.Mvc;

namespace AgendaBelezuza.Api.Controllers;

[ApiController]
[Route("api/[controller]")]
public class AgendamentosController : ControllerBase
{
    private readonly CriarAgendamentoService _service;

    public AgendamentosController(CriarAgendamentoService service)
    {
        _service = service;
    }

    [HttpPost]
    public async Task<IActionResult> Criar(CriarAgendamentoRequest request)
    {
        var result = await _service.ExecuteAsync(request);
        return CreatedAtAction(nameof(Criar), new { id = result.Id }, result);
    }
}
