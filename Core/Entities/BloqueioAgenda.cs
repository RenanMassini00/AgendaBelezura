namespace Core.Entities;

public class BloqueioAgenda
{
    public int Id { get; set; }
    public int ProfissionalId { get; set; }
    public Profissional Profissional { get; set; } = null!;

    public DateTime DataHoraInicio { get; set; }
    public DateTime DataHoraFim { get; set; }
    public string? Motivo { get; set; }

    public bool Ativo { get; set; } = true;
    public DateTime CriadoEm { get; set; } = DateTime.UtcNow;
    public DateTime? AtualizadoEm { get; set; }
}
