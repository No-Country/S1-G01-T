using Microsoft.EntityFrameworkCore.Migrations;

namespace DigiLearn.Data.Migrations
{
    public partial class UpToDateMigrations : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Nombre",
                table: "ActividadRelacionImagenPalabra",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Nombre",
                table: "ActividadRelacionImagenPalabra");
        }
    }
}
