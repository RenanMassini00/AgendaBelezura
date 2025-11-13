namespace Core.Entities;

public class Cliente
{
    public int Id { get; set; }
    public string Nome { get; set; } = null!;
    public string? Telefone { get; set; }
    public string? Email { get; set; }
    public string? Documento { get; set; }
    public bool Ativo { get; set; } = true;
    public DateTime CriadoEm { get; set; } = DateTime.UtcNow;
    public DateTime? AtualizadoEm { get; set; }

    public List<Agendamento> Agendamentos { get; set; } = new();
}
