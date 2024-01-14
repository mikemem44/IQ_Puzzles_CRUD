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
                name: "FK_RolFormulario_Formulario_FormularioID",
                table: "RolFormulario");

            migrationBuilder.DropForeignKey(
                name: "FK_RolFormulario_Rol_RolID",
                table: "RolFormulario");

            migrationBuilder.DropForeignKey(
                name: "FK_Usuario_Permiso_PermisoID",
                table: "Usuario");

            migrationBuilder.DropIndex(
                name: "IX_Usuario_PermisoID",
                table: "Usuario");

            migrationBuilder.DropPrimaryKey(
                name: "PK_RolFormulario",
                table: "RolFormulario");

            migrationBuilder.DropColumn(
                name: "PermisoID",
                table: "Usuario");

            migrationBuilder.RenameTable(
                name: "RolFormulario",
                newName: "UsuarioPermiso");

            migrationBuilder.RenameIndex(
                name: "IX_RolFormulario_RolID",
                table: "UsuarioPermiso",
                newName: "IX_UsuarioPermiso_RolID");

            migrationBuilder.RenameIndex(
                name: "IX_RolFormulario_FormularioID",
                table: "UsuarioPermiso",
                newName: "IX_UsuarioPermiso_FormularioID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_UsuarioPermiso",
                table: "UsuarioPermiso",
                column: "ID");

            migrationBuilder.CreateTable(
                name: "UsuarioPermisos",
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
                    table.PrimaryKey("PK_UsuarioPermisos", x => x.ID);
                    table.ForeignKey(
                        name: "FK_UsuarioPermisos_Permiso_PermisoID",
                        column: x => x.PermisoID,
                        principalTable: "Permiso",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UsuarioPermisos_Usuario_UsuarioID",
                        column: x => x.UsuarioID,
                        principalTable: "Usuario",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_UsuarioPermisos_PermisoID",
                table: "UsuarioPermisos",
                column: "PermisoID");

            migrationBuilder.CreateIndex(
                name: "IX_UsuarioPermisos_UsuarioID",
                table: "UsuarioPermisos",
                column: "UsuarioID");

            migrationBuilder.AddForeignKey(
                name: "FK_UsuarioPermiso_Formulario_FormularioID",
                table: "UsuarioPermiso",
                column: "FormularioID",
                principalTable: "Formulario",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_UsuarioPermiso_Rol_RolID",
                table: "UsuarioPermiso",
                column: "RolID",
                principalTable: "Rol",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_UsuarioPermiso_Formulario_FormularioID",
                table: "UsuarioPermiso");

            migrationBuilder.DropForeignKey(
                name: "FK_UsuarioPermiso_Rol_RolID",
                table: "UsuarioPermiso");

            migrationBuilder.DropTable(
                name: "UsuarioPermisos");

            migrationBuilder.DropPrimaryKey(
                name: "PK_UsuarioPermiso",
                table: "UsuarioPermiso");

            migrationBuilder.RenameTable(
                name: "UsuarioPermiso",
                newName: "RolFormulario");

            migrationBuilder.RenameIndex(
                name: "IX_UsuarioPermiso_RolID",
                table: "RolFormulario",
                newName: "IX_RolFormulario_RolID");

            migrationBuilder.RenameIndex(
                name: "IX_UsuarioPermiso_FormularioID",
                table: "RolFormulario",
                newName: "IX_RolFormulario_FormularioID");

            migrationBuilder.AddColumn<short>(
                name: "PermisoID",
                table: "Usuario",
                type: "smallint",
                nullable: false,
                defaultValue: (short)0);

            migrationBuilder.AddPrimaryKey(
                name: "PK_RolFormulario",
                table: "RolFormulario",
                column: "ID");

            migrationBuilder.CreateIndex(
                name: "IX_Usuario_PermisoID",
                table: "Usuario",
                column: "PermisoID");

            migrationBuilder.AddForeignKey(
                name: "FK_RolFormulario_Formulario_FormularioID",
                table: "RolFormulario",
                column: "FormularioID",
                principalTable: "Formulario",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_RolFormulario_Rol_RolID",
                table: "RolFormulario",
                column: "RolID",
                principalTable: "Rol",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

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
