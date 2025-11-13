namespace Core.Entities;

public class Profissional
{
    public int Id { get; set; }
    public int? UsuarioId { get; set; }
    public Usuario? Usuario { get; set; }

    public string NomePublico { get; set; } = null!;
    public string? Telefone { get; set; }
    public string? Documento { get; set; }
    public string? Descricao { get; set; }
    public bool Ativo { get; set; } = true;
    public DateTime CriadoEm { get; set; } = DateTime.UtcNow;
    public DateTime? AtualizadoEm { get; set; }

    public List<Servico> Servicos { get; set; } = new();
    public List<HorarioFuncionamento> HorariosFuncionamento { get; set; } = new();
    public List<BloqueioAgenda> BloqueiosAgenda { get; set; } = new();
    public List<Agendamento> Agendamentos { get; set; } = new();
    public ConfiguracaoProfissional? Configuracao { get; set; }
}
