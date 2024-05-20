using ImaginaTuMundo.Shared.Entidades;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace ImaginaTuMundo.API.Data
{
    public class DataContext:IdentityDbContext<User>
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }

        public DbSet<AsignacionMadreNinio> AsignacionesMadresNinios { get; set; }
        public DbSet<Asociacion> Asociaciones { get; set; }
        public DbSet<Evidencia> Evidencias { get; set; }
        public DbSet<ICBF> ICBFs { get; set; }
        public DbSet<MadreComunitaria> MadresComunitarias { get; set; }
        public DbSet<Ninios> Ninios { get; set; }
        public DbSet<RepresentanteLegal> RepresentantesLegales { get; set; }
        public DbSet<SeguimientoNinios> SeguimientosNinios { get; set; }
        public DbSet<TareaParaMadre> TareasParaMadres { get; set; }
        public DbSet<Inscripcion> Inscripciones { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
