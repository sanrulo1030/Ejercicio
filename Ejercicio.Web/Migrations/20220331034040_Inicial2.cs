using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Ejercicio.Web.Migrations
{
    public partial class Inicial2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Barrio",
                table: "Barrio");

            migrationBuilder.RenameTable(
                name: "Barrio",
                newName: "Barrios");

            migrationBuilder.RenameIndex(
                name: "IX_Barrio_Name",
                table: "Barrios",
                newName: "IX_Barrios_Name");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Barrios",
                table: "Barrios",
                column: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Barrios",
                table: "Barrios");

            migrationBuilder.RenameTable(
                name: "Barrios",
                newName: "Barrio");

            migrationBuilder.RenameIndex(
                name: "IX_Barrios_Name",
                table: "Barrio",
                newName: "IX_Barrio_Name");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Barrio",
                table: "Barrio",
                column: "Id");
        }
    }
}
