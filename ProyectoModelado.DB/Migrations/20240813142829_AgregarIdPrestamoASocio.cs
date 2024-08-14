using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProyectoModelado.DB.Migrations
{
    /// <inheritdoc />
    public partial class AgregarIdPrestamoASocio : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "IdPrestamo",
                table: "Socios",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IdPrestamo",
                table: "Socios");
        }
    }
}
