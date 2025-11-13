namespace Core.Entities;

public class ConfiguracaoProfissional
{
    public int Id { get; set; }
    public int ProfissionalId { get; set; }
    public Profissional Profissional { get; set; } = null!;

    public int IntervaloSlotsMinutos { get; set; } = 15;
    public int AntecedenciaMinimaHoras { get; set; } = 1;
    public int CancelamentoMinimoHoras { get; set; } = 2;
    public bool PermiteAgendamentoOnline { get; set; } = true;

    public DateTime CriadoEm { get; set; } = DateTime.UtcNow;
    public DateTime? AtualizadoEm { get; set; }
}
