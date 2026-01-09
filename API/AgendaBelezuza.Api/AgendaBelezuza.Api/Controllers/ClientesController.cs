using AgendaBelezuza.Application.DTOs.Clientes;
using AgendaBelezuza.Application.Services.Clientes;
using Microsoft.AspNetCore.Mvc;

namespace AgendaBelezuza.Api.Controllers;

[ApiController]
[Route("api/[controller]")]
public class ClientesController : ControllerBase
{
    private readonly CriarClienteService _service;

    public ClientesController(CriarClienteService service)
    {
        _service = service;
    }

    [HttpPost]
    public async Task<IActionResult> Criar(CriarClienteRequest request)
    {
        var result = await _service.ExecuteAsync(request);
        return CreatedAtAction(nameof(Criar), new { id = result.Id }, result);
    }
}
