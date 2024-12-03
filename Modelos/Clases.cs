using System.ComponentModel.DataAnnotations;

public class Usuario
{
    public int UsuarioId { get; set; }

    [Required(ErrorMessage = "El nombre de usuario es obligatorio.")]
    public string NombreUsuario { get; set; }

    [Required(ErrorMessage = "El correo es obligatorio.")]
    [EmailAddress(ErrorMessage = "El correo no tiene un formato válido.")]
    public string Correo { get; set; }

    [Required(ErrorMessage = "La clave es obligatoria.")]
    [StringLength(100, MinimumLength = 6, ErrorMessage = "La clave debe tener al menos 6 caracteres.")]
    public string Clave { get; set; }
    public ICollection<Vivencia> Vivencias { get; set; } = new List<Vivencia>();
}

public class Vivencia
{
    public int VivenciaId { get; set; }

    [Required(ErrorMessage = "El título es obligatorio.")]
    [StringLength(100, ErrorMessage = "El título no debe exceder los 100 caracteres.")]
    public string Titulo { get; set; }

     [Required(ErrorMessage = "La descripción es obligatoria.")]
    [StringLength(500, ErrorMessage = "La descripción no debe exceder los 500 caracteres.")]
    public string Descripcion { get; set; }

    [Required(ErrorMessage = "La ruta de la imagen es obligatoria.")]
    public DateTime Fecha { get; set; } = DateTime.Now;
    public string? ImagenRuta { get; set; }
    public int UsuarioId { get; set; }
    public Usuario Usuario { get; set; }
}


public class LoginModel
{
    [Required(ErrorMessage = "El correo es obligatorio.")]
    [EmailAddress(ErrorMessage = "El correo no tiene un formato válido.")]
    public string Correo { get; set; }

    [Required(ErrorMessage = "La clave es obligatoria.")]
    [StringLength(100, MinimumLength = 6, ErrorMessage = "La clave debe tener al menos 6 caracteres.")]
    public string Clave { get; set; }
}
