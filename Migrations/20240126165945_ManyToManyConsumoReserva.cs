using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HotelEF.Migrations
{
    /// <inheritdoc />
    public partial class ManyToManyConsumoReserva : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ReservaID",
                table: "Servico");

            migrationBuilder.CreateTable(
                name: "Consumo",
                columns: table => new
                {
                    ConsumoID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NomeItem = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Preco = table.Column<double>(type: "float", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Consumo", x => x.ConsumoID);
                });

            migrationBuilder.CreateTable(
                name: "ConsumoReserva",
                columns: table => new
                {
                    ConsumoID = table.Column<int>(type: "int", nullable: false),
                    ReservasReservaID = table.Column<int>(type: "int", nullable: false),
                    Quantidade = table.Column<int>(type: "int", nullable: true),
                    ServicoQuarto = table.Column<bool>(type: "bit", nullable: true),
                    ReservaID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ConsumoReserva", x => new { x.ConsumoID, x.ReservasReservaID });
                    table.ForeignKey(
                        name: "FK_ConsumoReserva_Consumo_ConsumoID",
                        column: x => x.ConsumoID,
                        principalTable: "Consumo",
                        principalColumn: "ConsumoID");
                    table.ForeignKey(
                        name: "FK_ConsumoReserva_Reserva_ReservaID",
                        column: x => x.ReservaID,
                        principalTable: "Reserva",
                        principalColumn: "ReservaID");
                    table.ForeignKey(
                        name: "FK_ConsumoReserva_Reserva_ReservasReservaID",
                        column: x => x.ReservasReservaID,
                        principalTable: "Reserva",
                        principalColumn: "ReservaID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ConsumoReserva_ConsumoID",
                table: "ConsumoReserva",
                column: "ConsumoID",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_ConsumoReserva_ReservaID",
                table: "ConsumoReserva",
                column: "ReservaID",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_ConsumoReserva_ReservasReservaID",
                table: "ConsumoReserva",
                column: "ReservasReservaID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ConsumoReserva");

            migrationBuilder.DropTable(
                name: "Consumo");

            migrationBuilder.AddColumn<int>(
                name: "ReservaID",
                table: "Servico",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
