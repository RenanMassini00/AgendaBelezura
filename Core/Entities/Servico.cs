namespace Core.Entities;

public class Servico
{
    public int Id { get; set; }
    public int ProfissionalId { get; set; }
    public Profissional Profissional { get; set; } = null!;

    public string Nome { get; set; } = null!;
    public string? Descricao { get; set; }
    public int DuracaoMinutos { get; set; }
    public decimal Preco { get; set; }
    public bool Ativo { get; set; } = true;
    public DateTime CriadoEm { get; set; } = DateTime.UtcNow;
    public DateTime? AtualizadoEm { get; set; }

    public List<Agendamento> Agendamentos { get; set; } = new();
}
