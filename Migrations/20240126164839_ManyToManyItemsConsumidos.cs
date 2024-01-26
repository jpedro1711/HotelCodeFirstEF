using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HotelEF.Migrations
{
    /// <inheritdoc />
    public partial class ManyToManyItemsConsumidos : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Conta",
                columns: table => new
                {
                    ReservaID = table.Column<int>(type: "int", nullable: false),
                    ItemConsumivelID = table.Column<int>(type: "int", nullable: false),
                    Quantidade = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Conta", x => new { x.ItemConsumivelID, x.ReservaID });
                    table.ForeignKey(
                        name: "FK_Conta_ItemConsumivel_ItemConsumivelID",
                        column: x => x.ItemConsumivelID,
                        principalTable: "ItemConsumivel",
                        principalColumn: "ItemConsumivelID");
                    table.ForeignKey(
                        name: "FK_Conta_Reserva_ReservaID",
                        column: x => x.ReservaID,
                        principalTable: "Reserva",
                        principalColumn: "ReservaID");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Conta_ItemConsumivelID",
                table: "Conta",
                column: "ItemConsumivelID",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Conta_ReservaID",
                table: "Conta",
                column: "ReservaID",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Conta");
        }
    }
}
