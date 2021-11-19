using Microsoft.EntityFrameworkCore.Migrations;

namespace Capa_Logica_Negocio.Migrations
{
    public partial class AnexoConusltasFactura : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "IdConsulta_Factura_Consulta",
                table: "tbl_Factura_Consulta",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_tbl_Factura_Consulta_IdConsulta_Factura_Consulta",
                table: "tbl_Factura_Consulta",
                column: "IdConsulta_Factura_Consulta");

            migrationBuilder.AddForeignKey(
                name: "FK_tbl_Factura_Consulta_tbl_Consulta_IdConsulta_Factura_Consulta",
                table: "tbl_Factura_Consulta",
                column: "IdConsulta_Factura_Consulta",
                principalTable: "tbl_Consulta",
                principalColumn: "Id_Consulta",
                onDelete: ReferentialAction.NoAction);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_tbl_Factura_Consulta_tbl_Consulta_IdConsulta_Factura_Consulta",
                table: "tbl_Factura_Consulta");

            migrationBuilder.DropIndex(
                name: "IX_tbl_Factura_Consulta_IdConsulta_Factura_Consulta",
                table: "tbl_Factura_Consulta");

            migrationBuilder.DropColumn(
                name: "IdConsulta_Factura_Consulta",
                table: "tbl_Factura_Consulta");
        }
    }
}
