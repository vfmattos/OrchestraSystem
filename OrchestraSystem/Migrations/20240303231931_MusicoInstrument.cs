using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace OrchestraSystem.Migrations
{
    public partial class MusicoInstrument : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Instrument_Musico_MusicoModelId",
                table: "Instrument");

            migrationBuilder.DropIndex(
                name: "IX_Instrument_MusicoModelId",
                table: "Instrument");

            migrationBuilder.DropColumn(
                name: "MusicoModelId",
                table: "Instrument");

            migrationBuilder.CreateTable(
                name: "MusicoInstrument",
                columns: table => new
                {
                    InstrumentsId = table.Column<int>(type: "int", nullable: false),
                    MusiciansId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MusicoInstrument", x => new { x.InstrumentsId, x.MusiciansId });
                    table.ForeignKey(
                        name: "FK_MusicoInstrument_Instrument_InstrumentsId",
                        column: x => x.InstrumentsId,
                        principalTable: "Instrument",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_MusicoInstrument_Musico_MusiciansId",
                        column: x => x.MusiciansId,
                        principalTable: "Musico",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateIndex(
                name: "IX_MusicoInstrument_MusiciansId",
                table: "MusicoInstrument",
                column: "MusiciansId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "MusicoInstrument");

            migrationBuilder.AddColumn<int>(
                name: "MusicoModelId",
                table: "Instrument",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Instrument_MusicoModelId",
                table: "Instrument",
                column: "MusicoModelId");

            migrationBuilder.AddForeignKey(
                name: "FK_Instrument_Musico_MusicoModelId",
                table: "Instrument",
                column: "MusicoModelId",
                principalTable: "Musico",
                principalColumn: "Id");
        }
    }
}
