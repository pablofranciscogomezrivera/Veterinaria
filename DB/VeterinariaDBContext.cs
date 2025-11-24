using Microsoft.EntityFrameworkCore;
using Veterinaria.Data;

namespace Veterinaria.DB
{
    public class VeterinariaDBContext : DbContext
    {
        public VeterinariaDBContext(DbContextOptions<VeterinariaDBContext> options)
            : base(options)
        {
        }

       
        public DbSet<Owner> Owners { get; set; } = null!;
        public DbSet<Mascota> Mascotas { get; set; } = null!;
        public DbSet<Atencion> Atenciones { get; set; } = null!;
       

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Mascota>()
                .HasOne(m => m.Owner)
                .WithMany(d => d.Mascotas)
                .HasForeignKey(m => m.IdOwner);

            modelBuilder.Entity<Atencion>()
                .HasOne(a => a.Mascota)
                .WithMany()
                .HasForeignKey(a => a.IdMascota);

            modelBuilder.Entity<Atencion>()
                .Property(a => a.Monto)
                .HasPrecision(18, 2); 
        }
    }
}