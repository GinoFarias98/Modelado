using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProyectoModelado.DB.Migrations
{
    /// <inheritdoc />
    public partial class TablasPrestamoYCuotas : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CantidadPrestamosMoroso",
                table: "Socios",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "CantidadTotalprestamos",
                table: "Socios",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<bool>(
                name: "EsMoroso",
                table: "Socios",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<DateTime>(
                name: "FechaVencimiento",
                table: "Cuotas",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.CreateTable(
                name: "Prestamo",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Detalle = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IdSocio = table.Column<int>(type: "int", nullable: false),
                    CuotasTotalesPrestamo = table.Column<int>(type: "int", nullable: false),
                    CuotasPagadasPrestamo = table.Column<int>(type: "int", nullable: false),
                    FechaInicio = table.Column<DateTime>(type: "datetime2", nullable: false),
                    FechaFin = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IdCuotaPrestamo = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Prestamo", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Prestamo_Socios_IdSocio",
                        column: x => x.IdSocio,
                        principalTable: "Socios",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "CuotaPrestamo",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdSocio = table.Column<int>(type: "int", nullable: false),
                    IdPrestamo = table.Column<int>(type: "int", nullable: false),
                    MontoCuota = table.Column<int>(type: "int", nullable: false),
                    FechaInicio = table.Column<DateTime>(type: "datetime2", nullable: false),
                    FechaFin = table.Column<DateTime>(type: "datetime2", nullable: false),
                    FechaVencimiento = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CuotaAdeudada = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CuotaPrestamo", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CuotaPrestamo_Prestamo_IdPrestamo",
                        column: x => x.IdPrestamo,
                        principalTable: "Prestamo",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_CuotaPrestamo_Socios_IdSocio",
                        column: x => x.IdSocio,
                        principalTable: "Socios",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CuotaPrestamo_IdPrestamo",
                table: "CuotaPrestamo",
                column: "IdPrestamo");

            migrationBuilder.CreateIndex(
                name: "IX_CuotaPrestamo_IdSocio",
                table: "CuotaPrestamo",
                column: "IdSocio");

            migrationBuilder.CreateIndex(
                name: "IX_Prestamo_IdSocio",
                table: "Prestamo",
                column: "IdSocio");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CuotaPrestamo");

            migrationBuilder.DropTable(
                name: "Prestamo");

            migrationBuilder.DropColumn(
                name: "CantidadPrestamosMoroso",
                table: "Socios");

            migrationBuilder.DropColumn(
                name: "CantidadTotalprestamos",
                table: "Socios");

            migrationBuilder.DropColumn(
                name: "EsMoroso",
                table: "Socios");

            migrationBuilder.DropColumn(
                name: "FechaVencimiento",
                table: "Cuotas");
        }
    }
}
