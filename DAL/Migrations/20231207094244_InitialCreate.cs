using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DAL.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Cliente",
                columns: table => new
                {
                    ID = table.Column<short>(type: "smallint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Apellido = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Correo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Telefono = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Activo = table.Column<bool>(type: "bit", nullable: false),
                    usuarioRegistro = table.Column<short>(type: "smallint", nullable: true),
                    fechaRegistro = table.Column<DateTime>(type: "datetime2", nullable: true),
                    usuarioActualiza = table.Column<short>(type: "smallint", nullable: true),
                    fechaActualizacion = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cliente", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Formulario",
                columns: table => new
                {
                    ID = table.Column<short>(type: "smallint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nombreFormulario = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Activo = table.Column<bool>(type: "bit", nullable: false),
                    usuarioRegistro = table.Column<short>(type: "smallint", nullable: true),
                    fechaRegistro = table.Column<DateTime>(type: "datetime2", nullable: true),
                    usuarioActualiza = table.Column<short>(type: "smallint", nullable: true),
                    fechaActualizacion = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Formulario", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Marca",
                columns: table => new
                {
                    ID = table.Column<short>(type: "smallint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nombreMarca = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Activo = table.Column<bool>(type: "bit", nullable: false),
                    usuarioRegistro = table.Column<short>(type: "smallint", nullable: true),
                    fechaRegistro = table.Column<DateTime>(type: "datetime2", nullable: true),
                    usuarioActualiza = table.Column<short>(type: "smallint", nullable: true),
                    fechaActualizacion = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Marca", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Modelo",
                columns: table => new
                {
                    ID = table.Column<short>(type: "smallint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nombreModelo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Activo = table.Column<bool>(type: "bit", nullable: false),
                    usuarioRegistro = table.Column<short>(type: "smallint", nullable: true),
                    fechaRegistro = table.Column<DateTime>(type: "datetime2", nullable: true),
                    usuarioActualiza = table.Column<short>(type: "smallint", nullable: true),
                    fechaActualizacion = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Modelo", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Permiso",
                columns: table => new
                {
                    ID = table.Column<short>(type: "smallint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nombrePermiso = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Activo = table.Column<bool>(type: "bit", nullable: false),
                    usuarioRegistro = table.Column<short>(type: "smallint", nullable: true),
                    fechaRegistro = table.Column<DateTime>(type: "datetime2", nullable: true),
                    usuarioActualiza = table.Column<short>(type: "smallint", nullable: true),
                    fechaActualizacion = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Permiso", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Rol",
                columns: table => new
                {
                    ID = table.Column<short>(type: "smallint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nombreRol = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Activo = table.Column<bool>(type: "bit", nullable: false),
                    usuarioRegistro = table.Column<short>(type: "smallint", nullable: true),
                    fechaRegistro = table.Column<DateTime>(type: "datetime2", nullable: true),
                    usuarioActualiza = table.Column<short>(type: "smallint", nullable: true),
                    fechaActualizacion = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Rol", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Producto",
                columns: table => new
                {
                    ID = table.Column<short>(type: "smallint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ModeloID = table.Column<short>(type: "smallint", nullable: false),
                    MarcaID = table.Column<short>(type: "smallint", nullable: false),
                    nombreProducto = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    precioUnitario = table.Column<decimal>(type: "decimal(6,2)", nullable: false),
                    Activo = table.Column<bool>(type: "bit", nullable: false),
                    Stock = table.Column<short>(type: "smallint", nullable: false),
                    usuarioRegistro = table.Column<short>(type: "smallint", nullable: true),
                    fechaRegistro = table.Column<DateTime>(type: "datetime2", nullable: true),
                    usuarioActualiza = table.Column<short>(type: "smallint", nullable: true),
                    fechaActualizacion = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Producto", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Producto_Marca_MarcaID",
                        column: x => x.MarcaID,
                        principalTable: "Marca",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Producto_Modelo_ModeloID",
                        column: x => x.ModeloID,
                        principalTable: "Modelo",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Usuario",
                columns: table => new
                {
                    ID = table.Column<short>(type: "smallint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Username = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PermisoID = table.Column<short>(type: "smallint", nullable: false),
                    Correo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Contrasena = table.Column<byte[]>(type: "varbinary(max)", nullable: false),
                    Bloqueado = table.Column<bool>(type: "bit", nullable: false, defaultValue: false),
                    Activo = table.Column<bool>(type: "bit", nullable: false),
                    usuarioRegistro = table.Column<short>(type: "smallint", nullable: true),
                    fechaRegistro = table.Column<DateTime>(type: "datetime2", nullable: true),
                    usuarioActualiza = table.Column<short>(type: "smallint", nullable: true),
                    fechaActualizacion = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Usuario", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Usuario_Permiso_PermisoID",
                        column: x => x.PermisoID,
                        principalTable: "Permiso",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "RolFormulario",
                columns: table => new
                {
                    ID = table.Column<short>(type: "smallint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RolID = table.Column<short>(type: "smallint", nullable: false),
                    FormularioID = table.Column<short>(type: "smallint", nullable: false),
                    Activo = table.Column<bool>(type: "bit", nullable: false),
                    usuarioRegistro = table.Column<short>(type: "smallint", nullable: true),
                    fechaRegistro = table.Column<DateTime>(type: "datetime2", nullable: true),
                    usuarioActualiza = table.Column<short>(type: "smallint", nullable: true),
                    fechaActualizacion = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RolFormulario", x => x.ID);
                    table.ForeignKey(
                        name: "FK_RolFormulario_Formulario_FormularioID",
                        column: x => x.FormularioID,
                        principalTable: "Formulario",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_RolFormulario_Rol_RolID",
                        column: x => x.RolID,
                        principalTable: "Rol",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Factura",
                columns: table => new
                {
                    ID = table.Column<short>(type: "smallint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ClienteID = table.Column<short>(type: "smallint", nullable: false),
                    UsuarioID = table.Column<short>(type: "smallint", nullable: false),
                    fechaCompra = table.Column<DateTime>(type: "datetime2", nullable: false),
                    totalCompra = table.Column<decimal>(type: "decimal(6,2)", nullable: false),
                    montoPagado = table.Column<decimal>(type: "decimal(6,2)", nullable: false),
                    Cambio = table.Column<decimal>(type: "decimal(6,2)", nullable: false),
                    Activo = table.Column<bool>(type: "bit", nullable: false),
                    usuarioRegistro = table.Column<short>(type: "smallint", nullable: true),
                    fechaRegistro = table.Column<DateTime>(type: "datetime2", nullable: true),
                    usuarioActualiza = table.Column<short>(type: "smallint", nullable: true),
                    fechaActualizacion = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Factura", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Factura_Cliente_ClienteID",
                        column: x => x.ClienteID,
                        principalTable: "Cliente",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Factura_Usuario_UsuarioID",
                        column: x => x.UsuarioID,
                        principalTable: "Usuario",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "RolUsuario",
                columns: table => new
                {
                    ID = table.Column<short>(type: "smallint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UsuarioID = table.Column<short>(type: "smallint", nullable: false),
                    RolID = table.Column<short>(type: "smallint", nullable: false),
                    Activo = table.Column<bool>(type: "bit", nullable: false),
                    usuarioRegistro = table.Column<short>(type: "smallint", nullable: true),
                    fechaRegistro = table.Column<DateTime>(type: "datetime2", nullable: true),
                    usuarioActualiza = table.Column<short>(type: "smallint", nullable: true),
                    fechaActualizacion = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RolUsuario", x => x.ID);
                    table.ForeignKey(
                        name: "FK_RolUsuario_Rol_RolID",
                        column: x => x.RolID,
                        principalTable: "Rol",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_RolUsuario_Usuario_UsuarioID",
                        column: x => x.UsuarioID,
                        principalTable: "Usuario",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Detalle",
                columns: table => new
                {
                    ID = table.Column<short>(type: "smallint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductoID = table.Column<short>(type: "smallint", nullable: false),
                    FacturaID = table.Column<short>(type: "smallint", nullable: false),
                    precioVenta = table.Column<decimal>(type: "decimal(6,2)", nullable: false),
                    Cantidad = table.Column<short>(type: "smallint", nullable: false),
                    Descuento = table.Column<float>(type: "real", nullable: false),
                    totalDetalle = table.Column<decimal>(type: "decimal(6,2)", nullable: false),
                    usuarioRegistro = table.Column<short>(type: "smallint", nullable: true),
                    fechaRegistro = table.Column<DateTime>(type: "datetime2", nullable: true),
                    usuarioActualiza = table.Column<short>(type: "smallint", nullable: true),
                    fechaActualizacion = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Detalle", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Detalle_Factura_FacturaID",
                        column: x => x.FacturaID,
                        principalTable: "Factura",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Detalle_Producto_ProductoID",
                        column: x => x.ProductoID,
                        principalTable: "Producto",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Detalle_FacturaID",
                table: "Detalle",
                column: "FacturaID");

            migrationBuilder.CreateIndex(
                name: "IX_Detalle_ProductoID",
                table: "Detalle",
                column: "ProductoID",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Factura_ClienteID",
                table: "Factura",
                column: "ClienteID");

            migrationBuilder.CreateIndex(
                name: "IX_Factura_UsuarioID",
                table: "Factura",
                column: "UsuarioID");

            migrationBuilder.CreateIndex(
                name: "IX_Producto_MarcaID",
                table: "Producto",
                column: "MarcaID");

            migrationBuilder.CreateIndex(
                name: "IX_Producto_ModeloID",
                table: "Producto",
                column: "ModeloID");

            migrationBuilder.CreateIndex(
                name: "IX_RolFormulario_FormularioID",
                table: "RolFormulario",
                column: "FormularioID");

            migrationBuilder.CreateIndex(
                name: "IX_RolFormulario_RolID",
                table: "RolFormulario",
                column: "RolID");

            migrationBuilder.CreateIndex(
                name: "IX_RolUsuario_RolID",
                table: "RolUsuario",
                column: "RolID");

            migrationBuilder.CreateIndex(
                name: "IX_RolUsuario_UsuarioID",
                table: "RolUsuario",
                column: "UsuarioID");

            migrationBuilder.CreateIndex(
                name: "IX_Usuario_PermisoID",
                table: "Usuario",
                column: "PermisoID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Detalle");

            migrationBuilder.DropTable(
                name: "RolFormulario");

            migrationBuilder.DropTable(
                name: "RolUsuario");

            migrationBuilder.DropTable(
                name: "Factura");

            migrationBuilder.DropTable(
                name: "Producto");

            migrationBuilder.DropTable(
                name: "Formulario");

            migrationBuilder.DropTable(
                name: "Rol");

            migrationBuilder.DropTable(
                name: "Cliente");

            migrationBuilder.DropTable(
                name: "Usuario");

            migrationBuilder.DropTable(
                name: "Marca");

            migrationBuilder.DropTable(
                name: "Modelo");

            migrationBuilder.DropTable(
                name: "Permiso");
        }
    }
}
