using AgendaBelezuza.Domain.Exceptions;

namespace AgendaBelezuza.Domain.Entities;

public class Usuario
{
    public int Id { get; private set; }
    public string Nome { get; private set; } = null!;
    public string Email { get; private set; } = null!;
    public string SenhaHash { get; private set; } = null!;
    public bool Ativo { get; private set; }

    public DateTime CriadoEm { get; private set; }
    public DateTime? AtualizadoEm { get; private set; }

    public ICollection<UsuarioPerfil> Perfis { get; private set; } = new List<UsuarioPerfil>();

    protected Usuario() { }

    public Usuario(string nome, string email, string senhaHash)
    {
        if (string.IsNullOrWhiteSpace(nome))
            throw new DomainException("Nome é obrigatório.");

        if (string.IsNullOrWhiteSpace(email))
            throw new DomainException("Email é obrigatório.");

        Nome = nome;
        Email = email;
        SenhaHash = senhaHash;

        Ativo = true;
        CriadoEm = DateTime.UtcNow;
    }

    public void Atualizar(string nome, string email)
    {
        Nome = nome;
        Email = email;
        AtualizadoEm = DateTime.UtcNow;
    }

    public void Desativar()
    {
        Ativo = false;
        AtualizadoEm = DateTime.UtcNow;
    }
}
