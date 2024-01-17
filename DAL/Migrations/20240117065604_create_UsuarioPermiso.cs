using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DAL.Migrations
{
    public partial class create_UsuarioPermiso : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Usuario_Permiso_PermisoID",
                table: "Usuario");

            migrationBuilder.DropIndex(
                name: "IX_Usuario_PermisoID",
                table: "Usuario");

            migrationBuilder.DropColumn(
                name: "PermisoID",
                table: "Usuario");

            migrationBuilder.CreateTable(
                name: "UsuarioPermiso",
                columns: table => new
                {
                    ID = table.Column<short>(type: "smallint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UsuarioID = table.Column<short>(type: "smallint", nullable: false),
                    PermisoID = table.Column<short>(type: "smallint", nullable: false),
                    Activo = table.Column<bool>(type: "bit", nullable: false),
                    usuarioRegistro = table.Column<short>(type: "smallint", nullable: true),
                    fechaRegistro = table.Column<DateTime>(type: "datetime2", nullable: true),
                    usuarioActualiza = table.Column<short>(type: "smallint", nullable: true),
                    fechaActualizacion = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UsuarioPermiso", x => x.ID);
                    table.ForeignKey(
                        name: "FK_UsuarioPermiso_Permiso_PermisoID",
                        column: x => x.PermisoID,
                        principalTable: "Permiso",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UsuarioPermiso_Usuario_UsuarioID",
                        column: x => x.UsuarioID,
                        principalTable: "Usuario",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_UsuarioPermiso_PermisoID",
                table: "UsuarioPermiso",
                column: "PermisoID");

            migrationBuilder.CreateIndex(
                name: "IX_UsuarioPermiso_UsuarioID",
                table: "UsuarioPermiso",
                column: "UsuarioID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "UsuarioPermiso");

            migrationBuilder.AddColumn<short>(
                name: "PermisoID",
                table: "Usuario",
                type: "smallint",
                nullable: false,
                defaultValue: (short)0);

            migrationBuilder.CreateIndex(
                name: "IX_Usuario_PermisoID",
                table: "Usuario",
                column: "PermisoID");

            migrationBuilder.AddForeignKey(
                name: "FK_Usuario_Permiso_PermisoID",
                table: "Usuario",
                column: "PermisoID",
                principalTable: "Permiso",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
