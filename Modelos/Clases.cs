public class Usuario
{
    public int UsuarioId { get; set; }
    public string NombreUsuario { get; set; }
    public string Correo { get; set; }
    public string Clave { get; set; }
    public ICollection<Vivencia> Vivencias { get; set; } = new List<Vivencia>();
}

public class Vivencia
{
    public int VivenciaId { get; set; }
    public string Titulo { get; set; }
    public string Descripcion { get; set; }
    public DateTime Fecha { get; set; } = DateTime.Now;
    public string? ImagenRuta { get; set; }
    public int UsuarioId { get; set; }
    public Usuario Usuario { get; set; }
}
