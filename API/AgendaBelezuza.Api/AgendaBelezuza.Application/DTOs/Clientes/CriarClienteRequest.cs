namespace AgendaBelezuza.Application.DTOs.Clientes;

public class CriarClienteRequest
{
    public string Nome { get; set; } = null!;
    public string? Telefone { get; set; }
    public string? Email { get; set; }
    public string? Documento { get; set; }
}
