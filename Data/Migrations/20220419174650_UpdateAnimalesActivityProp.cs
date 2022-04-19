using Microsoft.EntityFrameworkCore.Migrations;

namespace DigiLearn.Data.Migrations
{
    public partial class UpdateAnimalesActivityProp : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "ProfesionalId",
                table: "ActividadReconocimientoAnimales",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "ProfesionalId",
                table: "ActividadReconocimientoAnimales",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");
        }
    }
}
