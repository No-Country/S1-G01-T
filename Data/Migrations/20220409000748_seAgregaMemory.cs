using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DigiLearn.Data.Migrations
{
    public partial class seAgregaMemory : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Memory",
                columns: table => new
                {
                    ActividadId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FechaRealizacion = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ProfesionalId = table.Column<int>(type: "int", nullable: false),
                    PacienteId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Memory", x => x.ActividadId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Memory");
        }
    }
}
