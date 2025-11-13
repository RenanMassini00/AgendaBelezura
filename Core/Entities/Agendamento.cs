namespace Core.Entities;

public class Agendamento
{
    public int Id { get; set; }

    public int ProfissionalId { get; set; }
    public Profissional Profissional { get; set; } = null!;

    public int ClienteId { get; set; }
    public Cliente Cliente { get; set; } = null!;

    public int ServicoId { get; set; }
    public Servico Servico { get; set; } = null!;

    public DateTime DataInicio { get; set; }
    public DateTime DataFim { get; set; }

    public string Status { get; set; } = "PENDENTE"; // pode virar enum depois
    public string? Observacoes { get; set; }

    public DateTime CriadoEm { get; set; } = DateTime.UtcNow;
    public DateTime? AtualizadoEm { get; set; }
}
