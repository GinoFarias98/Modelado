using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProyectoModelado.DB.Migrations
{
    /// <inheritdoc />
    public partial class MontoDeseadoPrestamo : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "EstadoPrestamo",
                table: "Prestamo",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<int>(
                name: "MontoPrestamo",
                table: "Prestamo",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "EstadoPrestamo",
                table: "Prestamo");

            migrationBuilder.DropColumn(
                name: "MontoPrestamo",
                table: "Prestamo");
        }
    }
}
