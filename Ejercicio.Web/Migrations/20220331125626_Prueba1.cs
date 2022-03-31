using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Ejercicio.Web.Migrations
{
    public partial class Prueba1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "MunicipioId",
                table: "Barrios",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Barrios_MunicipioId",
                table: "Barrios",
                column: "MunicipioId");

            migrationBuilder.AddForeignKey(
                name: "FK_Barrios_Municipios_MunicipioId",
                table: "Barrios",
                column: "MunicipioId",
                principalTable: "Municipios",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Barrios_Municipios_MunicipioId",
                table: "Barrios");

            migrationBuilder.DropIndex(
                name: "IX_Barrios_MunicipioId",
                table: "Barrios");

            migrationBuilder.DropColumn(
                name: "MunicipioId",
                table: "Barrios");
        }
    }
}
