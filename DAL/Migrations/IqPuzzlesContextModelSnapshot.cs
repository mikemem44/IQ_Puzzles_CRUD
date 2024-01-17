﻿// <auto-generated />
using System;
using DAL;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace DAL.Migrations
{
    [DbContext(typeof(IqPuzzlesContext))]
    partial class IqPuzzlesContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.25")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("EL.Cliente", b =>
                {
                    b.Property<short>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("smallint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<short>("ID"), 1L, 1);

                    b.Property<bool>("Activo")
                        .HasColumnType("bit");

                    b.Property<string>("Apellido")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Correo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Telefono")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("fechaActualizacion")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("fechaRegistro")
                        .HasColumnType("datetime2");

                    b.Property<short?>("usuarioActualiza")
                        .HasColumnType("smallint");

                    b.Property<short?>("usuarioRegistro")
                        .HasColumnType("smallint");

                    b.HasKey("ID");

                    b.ToTable("Cliente", (string)null);
                });

            modelBuilder.Entity("EL.Detalle", b =>
                {
                    b.Property<short>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("smallint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<short>("ID"), 1L, 1);

                    b.Property<bool>("Activo")
                        .HasColumnType("bit");

                    b.Property<short>("Cantidad")
                        .HasColumnType("smallint");

                    b.Property<float>("Descuento")
                        .HasColumnType("real");

                    b.Property<short>("FacturaID")
                        .HasColumnType("smallint");

                    b.Property<short>("ProductoID")
                        .HasColumnType("smallint");

                    b.Property<DateTime?>("fechaActualizacion")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("fechaRegistro")
                        .HasColumnType("datetime2");

                    b.Property<decimal>("precioVenta")
                        .HasColumnType("decimal(6,2)");

                    b.Property<decimal>("totalDetalle")
                        .HasColumnType("decimal(6,2)");

                    b.Property<short?>("usuarioActualiza")
                        .HasColumnType("smallint");

                    b.Property<short?>("usuarioRegistro")
                        .HasColumnType("smallint");

                    b.HasKey("ID");

                    b.HasIndex("FacturaID");

                    b.HasIndex("ProductoID");

                    b.ToTable("Detalle", (string)null);
                });

            modelBuilder.Entity("EL.Factura", b =>
                {
                    b.Property<short>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("smallint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<short>("ID"), 1L, 1);

                    b.Property<bool>("Activo")
                        .HasColumnType("bit");

                    b.Property<decimal>("Cambio")
                        .HasColumnType("decimal(6,2)");

                    b.Property<short>("ClienteID")
                        .HasColumnType("smallint");

                    b.Property<short>("UsuarioID")
                        .HasColumnType("smallint");

                    b.Property<DateTime?>("fechaActualizacion")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("fechaCompra")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("fechaRegistro")
                        .HasColumnType("datetime2");

                    b.Property<decimal>("montoPagado")
                        .HasColumnType("decimal(6,2)");

                    b.Property<decimal>("totalCompra")
                        .HasColumnType("decimal(6,2)");

                    b.Property<short?>("usuarioActualiza")
                        .HasColumnType("smallint");

                    b.Property<short?>("usuarioRegistro")
                        .HasColumnType("smallint");

                    b.HasKey("ID");

                    b.HasIndex("ClienteID");

                    b.HasIndex("UsuarioID");

                    b.ToTable("Factura", (string)null);
                });

            modelBuilder.Entity("EL.Formulario", b =>
                {
                    b.Property<short>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("smallint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<short>("ID"), 1L, 1);

                    b.Property<bool>("Activo")
                        .HasColumnType("bit");

                    b.Property<DateTime?>("fechaActualizacion")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("fechaRegistro")
                        .HasColumnType("datetime2");

                    b.Property<string>("nombreFormulario")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<short?>("usuarioActualiza")
                        .HasColumnType("smallint");

                    b.Property<short?>("usuarioRegistro")
                        .HasColumnType("smallint");

                    b.HasKey("ID");

                    b.ToTable("Formulario", (string)null);
                });

            modelBuilder.Entity("EL.Marca", b =>
                {
                    b.Property<short>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("smallint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<short>("ID"), 1L, 1);

                    b.Property<bool>("Activo")
                        .HasColumnType("bit");

                    b.Property<DateTime?>("fechaActualizacion")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("fechaRegistro")
                        .HasColumnType("datetime2");

                    b.Property<string>("nombreMarca")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<short?>("usuarioActualiza")
                        .HasColumnType("smallint");

                    b.Property<short?>("usuarioRegistro")
                        .HasColumnType("smallint");

                    b.HasKey("ID");

                    b.ToTable("Marca", (string)null);
                });

            modelBuilder.Entity("EL.Modelo", b =>
                {
                    b.Property<short>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("smallint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<short>("ID"), 1L, 1);

                    b.Property<bool>("Activo")
                        .HasColumnType("bit");

                    b.Property<DateTime?>("fechaActualizacion")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("fechaRegistro")
                        .HasColumnType("datetime2");

                    b.Property<string>("nombreModelo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<short?>("usuarioActualiza")
                        .HasColumnType("smallint");

                    b.Property<short?>("usuarioRegistro")
                        .HasColumnType("smallint");

                    b.HasKey("ID");

                    b.ToTable("Modelo", (string)null);
                });

            modelBuilder.Entity("EL.Permiso", b =>
                {
                    b.Property<short>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("smallint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<short>("ID"), 1L, 1);

                    b.Property<bool>("Activo")
                        .HasColumnType("bit");

                    b.Property<DateTime?>("fechaActualizacion")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("fechaRegistro")
                        .HasColumnType("datetime2");

                    b.Property<string>("nombrePermiso")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<short?>("usuarioActualiza")
                        .HasColumnType("smallint");

                    b.Property<short?>("usuarioRegistro")
                        .HasColumnType("smallint");

                    b.HasKey("ID");

                    b.ToTable("Permiso", (string)null);
                });

            modelBuilder.Entity("EL.Producto", b =>
                {
                    b.Property<short>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("smallint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<short>("ID"), 1L, 1);

                    b.Property<bool>("Activo")
                        .HasColumnType("bit");

                    b.Property<short>("MarcaID")
                        .HasColumnType("smallint");

                    b.Property<short>("ModeloID")
                        .HasColumnType("smallint");

                    b.Property<short>("Stock")
                        .HasColumnType("smallint");

                    b.Property<DateTime?>("fechaActualizacion")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("fechaRegistro")
                        .HasColumnType("datetime2");

                    b.Property<string>("nombreProducto")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("precioUnitario")
                        .HasColumnType("decimal(6,2)");

                    b.Property<short?>("usuarioActualiza")
                        .HasColumnType("smallint");

                    b.Property<short?>("usuarioRegistro")
                        .HasColumnType("smallint");

                    b.HasKey("ID");

                    b.HasIndex("MarcaID");

                    b.HasIndex("ModeloID");

                    b.ToTable("Producto", (string)null);
                });

            modelBuilder.Entity("EL.Rol", b =>
                {
                    b.Property<short>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("smallint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<short>("ID"), 1L, 1);

                    b.Property<bool>("Activo")
                        .HasColumnType("bit");

                    b.Property<DateTime?>("fechaActualizacion")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("fechaRegistro")
                        .HasColumnType("datetime2");

                    b.Property<string>("nombreRol")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<short?>("usuarioActualiza")
                        .HasColumnType("smallint");

                    b.Property<short?>("usuarioRegistro")
                        .HasColumnType("smallint");

                    b.HasKey("ID");

                    b.ToTable("Rol", (string)null);
                });

            modelBuilder.Entity("EL.RolFormulario", b =>
                {
                    b.Property<short>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("smallint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<short>("ID"), 1L, 1);

                    b.Property<bool>("Activo")
                        .HasColumnType("bit");

                    b.Property<short>("FormularioID")
                        .HasColumnType("smallint");

                    b.Property<short>("RolID")
                        .HasColumnType("smallint");

                    b.Property<DateTime?>("fechaActualizacion")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("fechaRegistro")
                        .HasColumnType("datetime2");

                    b.Property<short?>("usuarioActualiza")
                        .HasColumnType("smallint");

                    b.Property<short?>("usuarioRegistro")
                        .HasColumnType("smallint");

                    b.HasKey("ID");

                    b.HasIndex("FormularioID");

                    b.HasIndex("RolID");

                    b.ToTable("RolFormulario", (string)null);
                });

            modelBuilder.Entity("EL.RolUsuario", b =>
                {
                    b.Property<short>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("smallint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<short>("ID"), 1L, 1);

                    b.Property<bool>("Activo")
                        .HasColumnType("bit");

                    b.Property<short>("RolID")
                        .HasColumnType("smallint");

                    b.Property<short>("UsuarioID")
                        .HasColumnType("smallint");

                    b.Property<DateTime?>("fechaActualizacion")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("fechaRegistro")
                        .HasColumnType("datetime2");

                    b.Property<short?>("usuarioActualiza")
                        .HasColumnType("smallint");

                    b.Property<short?>("usuarioRegistro")
                        .HasColumnType("smallint");

                    b.HasKey("ID");

                    b.HasIndex("RolID");

                    b.HasIndex("UsuarioID");

                    b.ToTable("RolUsuario", (string)null);
                });

            modelBuilder.Entity("EL.Usuario", b =>
                {
                    b.Property<short>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("smallint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<short>("ID"), 1L, 1);

                    b.Property<bool>("Activo")
                        .HasColumnType("bit");

                    b.Property<bool>("Bloqueado")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bit")
                        .HasDefaultValue(false);

                    b.Property<short>("Contador")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("smallint")
                        .HasDefaultValue((short)0);

                    b.Property<byte[]>("Contrasena")
                        .IsRequired()
                        .HasColumnType("varbinary(max)");

                    b.Property<string>("Correo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("fechaActualizacion")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("fechaRegistro")
                        .HasColumnType("datetime2");

                    b.Property<short?>("usuarioActualiza")
                        .HasColumnType("smallint");

                    b.Property<short?>("usuarioRegistro")
                        .HasColumnType("smallint");

                    b.HasKey("ID");

                    b.ToTable("Usuario", (string)null);
                });

            modelBuilder.Entity("EL.UsuarioPermiso", b =>
                {
                    b.Property<short>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("smallint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<short>("ID"), 1L, 1);

                    b.Property<bool>("Activo")
                        .HasColumnType("bit");

                    b.Property<short>("PermisoID")
                        .HasColumnType("smallint");

                    b.Property<short>("UsuarioID")
                        .HasColumnType("smallint");

                    b.Property<DateTime?>("fechaActualizacion")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("fechaRegistro")
                        .HasColumnType("datetime2");

                    b.Property<short?>("usuarioActualiza")
                        .HasColumnType("smallint");

                    b.Property<short?>("usuarioRegistro")
                        .HasColumnType("smallint");

                    b.HasKey("ID");

                    b.HasIndex("PermisoID");

                    b.HasIndex("UsuarioID");

                    b.ToTable("UsuarioPermiso", (string)null);
                });

            modelBuilder.Entity("EL.Detalle", b =>
                {
                    b.HasOne("EL.Factura", "Factura")
                        .WithMany("Detalles")
                        .HasForeignKey("FacturaID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("EL.Producto", "Producto")
                        .WithMany("Detalles")
                        .HasForeignKey("ProductoID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Factura");

                    b.Navigation("Producto");
                });

            modelBuilder.Entity("EL.Factura", b =>
                {
                    b.HasOne("EL.Cliente", "Cliente")
                        .WithMany("Facturas")
                        .HasForeignKey("ClienteID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("EL.Usuario", "Usuario")
                        .WithMany("Facturas")
                        .HasForeignKey("UsuarioID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Cliente");

                    b.Navigation("Usuario");
                });

            modelBuilder.Entity("EL.Producto", b =>
                {
                    b.HasOne("EL.Marca", "Marca")
                        .WithMany("Productos")
                        .HasForeignKey("MarcaID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("EL.Modelo", "Modelo")
                        .WithMany("Productos")
                        .HasForeignKey("ModeloID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Marca");

                    b.Navigation("Modelo");
                });

            modelBuilder.Entity("EL.RolFormulario", b =>
                {
                    b.HasOne("EL.Formulario", null)
                        .WithMany("RolFormularios")
                        .HasForeignKey("FormularioID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("EL.Rol", null)
                        .WithMany("RolFormularios")
                        .HasForeignKey("RolID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("EL.RolUsuario", b =>
                {
                    b.HasOne("EL.Rol", null)
                        .WithMany("RolUsuarios")
                        .HasForeignKey("RolID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("EL.Usuario", null)
                        .WithMany("RolUsuarios")
                        .HasForeignKey("UsuarioID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("EL.UsuarioPermiso", b =>
                {
                    b.HasOne("EL.Permiso", null)
                        .WithMany("UsuarioPermisos")
                        .HasForeignKey("PermisoID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("EL.Usuario", null)
                        .WithMany("UsuarioPermisos")
                        .HasForeignKey("UsuarioID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("EL.Cliente", b =>
                {
                    b.Navigation("Facturas");
                });

            modelBuilder.Entity("EL.Factura", b =>
                {
                    b.Navigation("Detalles");
                });

            modelBuilder.Entity("EL.Formulario", b =>
                {
                    b.Navigation("RolFormularios");
                });

            modelBuilder.Entity("EL.Marca", b =>
                {
                    b.Navigation("Productos");
                });

            modelBuilder.Entity("EL.Modelo", b =>
                {
                    b.Navigation("Productos");
                });

            modelBuilder.Entity("EL.Permiso", b =>
                {
                    b.Navigation("UsuarioPermisos");
                });

            modelBuilder.Entity("EL.Producto", b =>
                {
                    b.Navigation("Detalles");
                });

            modelBuilder.Entity("EL.Rol", b =>
                {
                    b.Navigation("RolFormularios");

                    b.Navigation("RolUsuarios");
                });

            modelBuilder.Entity("EL.Usuario", b =>
                {
                    b.Navigation("Facturas");

                    b.Navigation("RolUsuarios");

                    b.Navigation("UsuarioPermisos");
                });
#pragma warning restore 612, 618
        }
    }
}
