using Microsoft.EntityFrameworkCore;

public class ContextoVivencia : DbContext
{
    public DbSet<Usuario> Usuarios { get; set; }
    public DbSet<Vivencia> Vivencias { get; set; }

    public ContextoVivencia(DbContextOptions<ContextoVivencia> options) : base(options) { }
}