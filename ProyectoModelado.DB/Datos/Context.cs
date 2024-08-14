using Microsoft.EntityFrameworkCore;
using ProyectoModelado.DB.Datos.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoModelado.DB.Datos
{
    public class Context : DbContext
    {
        public DbSet<Socio> Socios { get; set; }
        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Cuota> Cuotas { get; set; }
        public DbSet<Vehiculo> Vehiculos { get; set; }
        public DbSet<InfoRegistro> InfoRegistros { get; set; }
        public DbSet<Entrega> Entregas { get; set; }

        public Context(DbContextOptions options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            // Configuracion de CuotaPrestamo
            modelBuilder.Entity<CuotaPrestamo>()
                .HasOne(cp => cp.Socio)
                .WithMany(s => s.CuotasPrestamo)
                .HasForeignKey(cp => cp.IdSocio)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<CuotaPrestamo>()
                .HasOne(cp => cp.Prestamo)
                .WithMany(p => p.CuotasPrestamo)
                .HasForeignKey(cp => cp.IdPrestamo)
                .OnDelete(DeleteBehavior.Restrict);

            // Configuracipn de Prestamo
            modelBuilder.Entity<Prestamo>()
                .HasOne(p => p.Socio)
                .WithMany(s => s.Prestamos)
                .HasForeignKey(p => p.IdSocio)
                .OnDelete(DeleteBehavior.Restrict);

            // Relacion uno a muchos: Socio - Cuota
            modelBuilder.Entity<Socio>()
                .HasMany(s => s.Cuotas)
                .WithOne(c => c.Socio)
                .HasForeignKey(c => c.IdSocio);

            // Relacion uno a muchos: Cliente - Entrega
            modelBuilder.Entity<Cliente>()
                .HasMany(c => c.Entregas)
                .WithOne(e => e.Cliente)
                .HasForeignKey(e => e.IdCliente);

            // Relación uno a muchos: Socio - Vehiculo
            modelBuilder.Entity<Vehiculo>()
                .HasMany(v => v.Socios)
                .WithOne(s => s.Vehiculo)
                .HasForeignKey(s => s.IdVehiculo);


            var cascadeFKs = modelBuilder.Model.G­etEntityTypes()
                                         .SelectMany(t => t.GetForeignKeys())
                                         .Where(fk => !fk.IsOwnership
                                                      && fk.DeleteBehavior == DeleteBehavior.Casca­de);
            foreach (var fk in cascadeFKs)
            {
                fk.DeleteBehavior = DeleteBehavior.Restr­ict;
            }

            base.OnModelCreating(modelBuilder);
        }
    }
}
