using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HotelEF.Migrations
{
    /// <inheritdoc />
    public partial class ManyToManyServicoReserva : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Servico_Reserva_ReservaID",
                table: "Servico");

            migrationBuilder.DropIndex(
                name: "IX_Servico_ReservaID",
                table: "Servico");

            migrationBuilder.CreateTable(
                name: "ServicoReserva",
                columns: table => new
                {
                    ServicoID = table.Column<int>(type: "int", nullable: false),
                    ReservasReservaID = table.Column<int>(type: "int", nullable: false),
                    Quantidade = table.Column<int>(type: "int", nullable: false),
                    ReservaID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ServicoReserva", x => new { x.ReservasReservaID, x.ServicoID });
                    table.ForeignKey(
                        name: "FK_ServicoReserva_Reserva_ReservaID",
                        column: x => x.ReservaID,
                        principalTable: "Reserva",
                        principalColumn: "ReservaID");
                    table.ForeignKey(
                        name: "FK_ServicoReserva_Reserva_ReservasReservaID",
                        column: x => x.ReservasReservaID,
                        principalTable: "Reserva",
                        principalColumn: "ReservaID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ServicoReserva_Servico_ServicoID",
                        column: x => x.ServicoID,
                        principalTable: "Servico",
                        principalColumn: "ServicoID");
                });

            migrationBuilder.CreateIndex(
                name: "IX_ServicoReserva_ReservaID",
                table: "ServicoReserva",
                column: "ReservaID",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_ServicoReserva_ServicoID",
                table: "ServicoReserva",
                column: "ServicoID",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ServicoReserva");

            migrationBuilder.CreateIndex(
                name: "IX_Servico_ReservaID",
                table: "Servico",
                column: "ReservaID");

            migrationBuilder.AddForeignKey(
                name: "FK_Servico_Reserva_ReservaID",
                table: "Servico",
                column: "ReservaID",
                principalTable: "Reserva",
                principalColumn: "ReservaID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
