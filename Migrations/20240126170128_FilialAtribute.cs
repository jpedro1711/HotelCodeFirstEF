using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HotelEF.Migrations
{
    /// <inheritdoc />
    public partial class FilialAtribute : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "FilialID",
                table: "Reserva",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "FilialID",
                table: "Funcionario",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Reserva_FilialID",
                table: "Reserva",
                column: "FilialID");

            migrationBuilder.CreateIndex(
                name: "IX_Funcionario_FilialID",
                table: "Funcionario",
                column: "FilialID");

            migrationBuilder.AddForeignKey(
                name: "FK_Funcionario_Filial_FilialID",
                table: "Funcionario",
                column: "FilialID",
                principalTable: "Filial",
                principalColumn: "FilialID");

            migrationBuilder.AddForeignKey(
                name: "FK_Reserva_Filial_FilialID",
                table: "Reserva",
                column: "FilialID",
                principalTable: "Filial",
                principalColumn: "FilialID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Funcionario_Filial_FilialID",
                table: "Funcionario");

            migrationBuilder.DropForeignKey(
                name: "FK_Reserva_Filial_FilialID",
                table: "Reserva");

            migrationBuilder.DropIndex(
                name: "IX_Reserva_FilialID",
                table: "Reserva");

            migrationBuilder.DropIndex(
                name: "IX_Funcionario_FilialID",
                table: "Funcionario");

            migrationBuilder.DropColumn(
                name: "FilialID",
                table: "Reserva");

            migrationBuilder.DropColumn(
                name: "FilialID",
                table: "Funcionario");
        }
    }
}
