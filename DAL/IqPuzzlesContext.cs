using EL;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class IqPuzzlesContext : DbContext
    {
        public IqPuzzlesContext() { }

        public IqPuzzlesContext(DbContextOptions<IqPuzzlesContext> options) : base(options) { }

        public DbSet<Modelo> Modelos { get; set; }
        public DbSet<Marca> Marcas { get; set; }
        public DbSet<Producto> Productos { get; set; }
        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Factura> Facturas { get; set; }
        public DbSet<Detalle> Detalles { get; set; }
        public DbSet<Rol> Roles { get; set; }
        public DbSet<Permiso> Permisos { get; set; }
        public DbSet<Formulario> Formularios { get; set; }
        public DbSet<RolUsuario> RolUsuarios { get; set; }
        public DbSet<RolFormulario> RolFormularios { get; set; }
        public DbSet<UsuarioPermiso> UsuarioPermisos { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //nombres de tablas singulares
            modelBuilder.Entity<Modelo>().ToTable("Modelo");
            modelBuilder.Entity<Marca>().ToTable("Marca");
            modelBuilder.Entity<Producto>().ToTable("Producto");
            modelBuilder.Entity<Cliente>().ToTable("Cliente");
            modelBuilder.Entity<Usuario>().ToTable("Usuario");
            modelBuilder.Entity<Factura>().ToTable("Factura");
            modelBuilder.Entity<Detalle>().ToTable("Detalle");
            modelBuilder.Entity<Rol>().ToTable("Rol");
            modelBuilder.Entity<Permiso>().ToTable("Permiso");
            modelBuilder.Entity<Formulario>().ToTable("Formulario");
            modelBuilder.Entity<RolUsuario>().ToTable("RolUsuario");
            modelBuilder.Entity<RolFormulario>().ToTable("RolFormulario");
            modelBuilder.Entity<RolFormulario>().ToTable("UsuarioPermiso");


            modelBuilder.Entity<Rol>()
                .HasMany(e => e.Usuarios)
                .WithMany(e => e.Roles)
                .UsingEntity<RolUsuario>();

            modelBuilder.Entity<Rol>()
                .HasMany(e =>e.Formularios)
                .WithMany(e =>e.Roles)
                .UsingEntity<RolFormulario>();

            modelBuilder.Entity<Usuario>()
                .Property(e => e.Bloqueado)
                .HasDefaultValue(false);

            modelBuilder.Entity<Usuario>()
                .Property(e => e.Contador)
                .HasDefaultValue(0);

            modelBuilder.Entity<Usuario>()
                .HasMany(e => e.Permisos)
                .WithMany(e => e.Usuarios)
                .UsingEntity<UsuarioPermiso>();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=IQ_Puzzles_BD;Integrated Security=True;");
        }
    }
}
