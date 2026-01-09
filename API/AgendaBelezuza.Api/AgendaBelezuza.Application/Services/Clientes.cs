using AgendaBelezuza.Application.DTOs.Clientes;
using AgendaBelezuza.Application.Repositories;
using AgendaBelezuza.Domain.Entities;

namespace AgendaBelezuza.Application.Services.Clientes;

public class CriarClienteService
{
    private readonly IClienteRepository _repo;

    public CriarClienteService(IClienteRepository repo)
    {
        _repo = repo;
    }

    public async Task<CriarClienteResponse> ExecuteAsync(CriarClienteRequest req)
    {
        var cliente = new Cliente(req.Nome);

        if (!string.IsNullOrWhiteSpace(req.Email))
            cliente.GetType().GetProperty("Email")?.SetValue(cliente, req.Email);

        await _repo.AdicionarAsync(cliente);

        return new CriarClienteResponse
        {
            Id = cliente.Id,
            Nome = cliente.Nome
        };
    }
}
