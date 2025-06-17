using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ApiLaboratorial.Migrations
{
    /// <inheritdoc />
    public partial class MigracaoPostgresCorrigida : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Sensor",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Dispositivo = table.Column<string>(type: "text", nullable: false),
                    Temperatura = table.Column<double>(type: "double precision", nullable: false),
                    Bateria = table.Column<double>(type: "double precision", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sensor", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Sensor");
        }
    }
}
