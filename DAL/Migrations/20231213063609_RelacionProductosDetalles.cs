using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DAL.Migrations
{
    public partial class RelacionProductosDetalles : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Detalle_ProductoID",
                table: "Detalle");

            migrationBuilder.CreateIndex(
                name: "IX_Detalle_ProductoID",
                table: "Detalle",
                column: "ProductoID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Detalle_ProductoID",
                table: "Detalle");

            migrationBuilder.CreateIndex(
                name: "IX_Detalle_ProductoID",
                table: "Detalle",
                column: "ProductoID",
                unique: true);
        }
    }
}
