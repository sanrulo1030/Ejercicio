using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Ejercicio.Web.Migrations
{
    public partial class Inicial3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "BarrioId",
                table: "Alumnos",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "MunicipioId",
                table: "Alumnos",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Alumnos_BarrioId",
                table: "Alumnos",
                column: "BarrioId");

            migrationBuilder.CreateIndex(
                name: "IX_Alumnos_MunicipioId",
                table: "Alumnos",
                column: "MunicipioId");

            migrationBuilder.AddForeignKey(
                name: "FK_Alumnos_Barrios_BarrioId",
                table: "Alumnos",
                column: "BarrioId",
                principalTable: "Barrios",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Alumnos_Municipios_MunicipioId",
                table: "Alumnos",
                column: "MunicipioId",
                principalTable: "Municipios",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Alumnos_Barrios_BarrioId",
                table: "Alumnos");

            migrationBuilder.DropForeignKey(
                name: "FK_Alumnos_Municipios_MunicipioId",
                table: "Alumnos");

            migrationBuilder.DropIndex(
                name: "IX_Alumnos_BarrioId",
                table: "Alumnos");

            migrationBuilder.DropIndex(
                name: "IX_Alumnos_MunicipioId",
                table: "Alumnos");

            migrationBuilder.DropColumn(
                name: "BarrioId",
                table: "Alumnos");

            migrationBuilder.DropColumn(
                name: "MunicipioId",
                table: "Alumnos");
        }
    }
}
