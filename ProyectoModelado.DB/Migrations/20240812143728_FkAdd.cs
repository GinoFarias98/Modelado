using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProyectoModelado.DB.Migrations
{
    /// <inheritdoc />
    public partial class FkAdd : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IdVehiculo",
                table: "Vehiculos");

            migrationBuilder.DropColumn(
                name: "IdSocio",
                table: "Socios");

            migrationBuilder.DropColumn(
                name: "IdInfoRegistro",
                table: "InfoRegistros");

            migrationBuilder.DropColumn(
                name: "IdEntrega",
                table: "Entregas");

            migrationBuilder.DropColumn(
                name: "IdCuota",
                table: "Cuotas");

            migrationBuilder.DropColumn(
                name: "IdCLiente",
                table: "Clientes");

            migrationBuilder.CreateIndex(
                name: "IX_Socios_IdInfoRegistro",
                table: "Socios",
                column: "IdInfoRegistro");

            migrationBuilder.CreateIndex(
                name: "IX_Socios_IdVehiculo",
                table: "Socios",
                column: "IdVehiculo");

            migrationBuilder.CreateIndex(
                name: "IX_Entregas_IdCliente",
                table: "Entregas",
                column: "IdCliente");

            migrationBuilder.CreateIndex(
                name: "IX_Entregas_IdSocio",
                table: "Entregas",
                column: "IdSocio");

            migrationBuilder.CreateIndex(
                name: "IX_Cuotas_IdSocio",
                table: "Cuotas",
                column: "IdSocio");

            migrationBuilder.AddForeignKey(
                name: "FK_Cuotas_Socios_IdSocio",
                table: "Cuotas",
                column: "IdSocio",
                principalTable: "Socios",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Entregas_Clientes_IdCliente",
                table: "Entregas",
                column: "IdCliente",
                principalTable: "Clientes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Entregas_Socios_IdSocio",
                table: "Entregas",
                column: "IdSocio",
                principalTable: "Socios",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Socios_InfoRegistros_IdInfoRegistro",
                table: "Socios",
                column: "IdInfoRegistro",
                principalTable: "InfoRegistros",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Socios_Vehiculos_IdVehiculo",
                table: "Socios",
                column: "IdVehiculo",
                principalTable: "Vehiculos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Cuotas_Socios_IdSocio",
                table: "Cuotas");

            migrationBuilder.DropForeignKey(
                name: "FK_Entregas_Clientes_IdCliente",
                table: "Entregas");

            migrationBuilder.DropForeignKey(
                name: "FK_Entregas_Socios_IdSocio",
                table: "Entregas");

            migrationBuilder.DropForeignKey(
                name: "FK_Socios_InfoRegistros_IdInfoRegistro",
                table: "Socios");

            migrationBuilder.DropForeignKey(
                name: "FK_Socios_Vehiculos_IdVehiculo",
                table: "Socios");

            migrationBuilder.DropIndex(
                name: "IX_Socios_IdInfoRegistro",
                table: "Socios");

            migrationBuilder.DropIndex(
                name: "IX_Socios_IdVehiculo",
                table: "Socios");

            migrationBuilder.DropIndex(
                name: "IX_Entregas_IdCliente",
                table: "Entregas");

            migrationBuilder.DropIndex(
                name: "IX_Entregas_IdSocio",
                table: "Entregas");

            migrationBuilder.DropIndex(
                name: "IX_Cuotas_IdSocio",
                table: "Cuotas");

            migrationBuilder.AddColumn<int>(
                name: "IdVehiculo",
                table: "Vehiculos",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "IdSocio",
                table: "Socios",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "IdInfoRegistro",
                table: "InfoRegistros",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "IdEntrega",
                table: "Entregas",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "IdCuota",
                table: "Cuotas",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "IdCLiente",
                table: "Clientes",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
