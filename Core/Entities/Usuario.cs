namespace Core.Entities;

public class Usuario
{
	public int Id { get; set; }
	public string Nome { get; set; } = null!;
	public string Email { get; set; } = null!;
	public string SenhaHash { get; set; } = null!;
	public bool Ativo { get; set; } = true;
	public DateTime CriadoEm { get; set; } = DateTime.UtcNow;
	public DateTime? AtualizadoEm { get; set; }

	public List<UsuarioPerfil> UsuarioPerfis { get; set; } = new();
	public List<Profissional> Profissionais { get; set; } = new();
}