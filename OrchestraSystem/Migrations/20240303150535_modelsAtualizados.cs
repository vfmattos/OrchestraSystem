using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace OrchestraSystem.Migrations
{
    public partial class modelsAtualizados : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Musico_Orchestra_OrchestraId",
                table: "Musico");

            migrationBuilder.DropTable(
                name: "InstrumentModelMusicoModel");

            migrationBuilder.DropTable(
                name: "InstrumentModelSymphonyModel");

            migrationBuilder.DropTable(
                name: "OrchestraSymphony");

            migrationBuilder.DropTable(
                name: "SymphonyMusician");

            migrationBuilder.DropIndex(
                name: "IX_Musico_OrchestraId",
                table: "Musico");

            migrationBuilder.DropColumn(
                name: "OrchestraId",
                table: "Musico");

            migrationBuilder.AddColumn<int>(
                name: "OrchestraModelId",
                table: "Symphony",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "MusicoModelId",
                table: "Instrument",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "SymphonyModelId",
                table: "Instrument",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Symphony_OrchestraModelId",
                table: "Symphony",
                column: "OrchestraModelId");

            migrationBuilder.CreateIndex(
                name: "IX_Instrument_MusicoModelId",
                table: "Instrument",
                column: "MusicoModelId");

            migrationBuilder.CreateIndex(
                name: "IX_Instrument_SymphonyModelId",
                table: "Instrument",
                column: "SymphonyModelId");

            migrationBuilder.AddForeignKey(
                name: "FK_Instrument_Musico_MusicoModelId",
                table: "Instrument",
                column: "MusicoModelId",
                principalTable: "Musico",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Instrument_Symphony_SymphonyModelId",
                table: "Instrument",
                column: "SymphonyModelId",
                principalTable: "Symphony",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Symphony_Orchestra_OrchestraModelId",
                table: "Symphony",
                column: "OrchestraModelId",
                principalTable: "Orchestra",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Instrument_Musico_MusicoModelId",
                table: "Instrument");

            migrationBuilder.DropForeignKey(
                name: "FK_Instrument_Symphony_SymphonyModelId",
                table: "Instrument");

            migrationBuilder.DropForeignKey(
                name: "FK_Symphony_Orchestra_OrchestraModelId",
                table: "Symphony");

            migrationBuilder.DropIndex(
                name: "IX_Symphony_OrchestraModelId",
                table: "Symphony");

            migrationBuilder.DropIndex(
                name: "IX_Instrument_MusicoModelId",
                table: "Instrument");

            migrationBuilder.DropIndex(
                name: "IX_Instrument_SymphonyModelId",
                table: "Instrument");

            migrationBuilder.DropColumn(
                name: "OrchestraModelId",
                table: "Symphony");

            migrationBuilder.DropColumn(
                name: "MusicoModelId",
                table: "Instrument");

            migrationBuilder.DropColumn(
                name: "SymphonyModelId",
                table: "Instrument");

            migrationBuilder.AddColumn<int>(
                name: "OrchestraId",
                table: "Musico",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "InstrumentModelMusicoModel",
                columns: table => new
                {
                    InstrumentsId = table.Column<int>(type: "int", nullable: false),
                    MusiciansId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_InstrumentModelMusicoModel", x => new { x.InstrumentsId, x.MusiciansId });
                    table.ForeignKey(
                        name: "FK_InstrumentModelMusicoModel_Instrument_InstrumentsId",
                        column: x => x.InstrumentsId,
                        principalTable: "Instrument",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_InstrumentModelMusicoModel_Musico_MusiciansId",
                        column: x => x.MusiciansId,
                        principalTable: "Musico",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "InstrumentModelSymphonyModel",
                columns: table => new
                {
                    RequiredInstrumentsId = table.Column<int>(type: "int", nullable: false),
                    SymphoniesId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_InstrumentModelSymphonyModel", x => new { x.RequiredInstrumentsId, x.SymphoniesId });
                    table.ForeignKey(
                        name: "FK_InstrumentModelSymphonyModel_Instrument_RequiredInstrumentsId",
                        column: x => x.RequiredInstrumentsId,
                        principalTable: "Instrument",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_InstrumentModelSymphonyModel_Symphony_SymphoniesId",
                        column: x => x.SymphoniesId,
                        principalTable: "Symphony",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "OrchestraSymphony",
                columns: table => new
                {
                    OrchestraId = table.Column<int>(type: "int", nullable: false),
                    SymphonyId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrchestraSymphony", x => new { x.OrchestraId, x.SymphonyId });
                    table.ForeignKey(
                        name: "FK_OrchestraSymphony_Orchestra_OrchestraId",
                        column: x => x.OrchestraId,
                        principalTable: "Orchestra",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_OrchestraSymphony_Symphony_SymphonyId",
                        column: x => x.SymphonyId,
                        principalTable: "Symphony",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "SymphonyMusician",
                columns: table => new
                {
                    MusicianId = table.Column<int>(type: "int", nullable: false),
                    SymphonyId = table.Column<int>(type: "int", nullable: false),
                    InstrumentId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SymphonyMusician", x => new { x.MusicianId, x.SymphonyId });
                    table.ForeignKey(
                        name: "FK_SymphonyMusician_Instrument_InstrumentId",
                        column: x => x.InstrumentId,
                        principalTable: "Instrument",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SymphonyMusician_Musico_MusicianId",
                        column: x => x.MusicianId,
                        principalTable: "Musico",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SymphonyMusician_Symphony_SymphonyId",
                        column: x => x.SymphonyId,
                        principalTable: "Symphony",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateIndex(
                name: "IX_Musico_OrchestraId",
                table: "Musico",
                column: "OrchestraId");

            migrationBuilder.CreateIndex(
                name: "IX_InstrumentModelMusicoModel_MusiciansId",
                table: "InstrumentModelMusicoModel",
                column: "MusiciansId");

            migrationBuilder.CreateIndex(
                name: "IX_InstrumentModelSymphonyModel_SymphoniesId",
                table: "InstrumentModelSymphonyModel",
                column: "SymphoniesId");

            migrationBuilder.CreateIndex(
                name: "IX_OrchestraSymphony_SymphonyId",
                table: "OrchestraSymphony",
                column: "SymphonyId");

            migrationBuilder.CreateIndex(
                name: "IX_SymphonyMusician_InstrumentId",
                table: "SymphonyMusician",
                column: "InstrumentId");

            migrationBuilder.CreateIndex(
                name: "IX_SymphonyMusician_SymphonyId",
                table: "SymphonyMusician",
                column: "SymphonyId");

            migrationBuilder.AddForeignKey(
                name: "FK_Musico_Orchestra_OrchestraId",
                table: "Musico",
                column: "OrchestraId",
                principalTable: "Orchestra",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
