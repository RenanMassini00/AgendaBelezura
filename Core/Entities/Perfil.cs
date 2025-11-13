namespace Core.Entities;

public class Perfil
{
    public int Id { get; set; }
    public string Nome { get; set; } = null!;

    public List<UsuarioPerfil> UsuarioPerfis { get; set; } = new();
}
