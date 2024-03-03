using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace OrchestraSystem.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterDatabase()
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Instrument",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Instrument", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Orchestra",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    City = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Country = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    CreationDate = table.Column<DateTime>(type: "datetime(6)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Orchestra", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Symphony",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Composer = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    CreationDate = table.Column<DateTime>(type: "datetime(6)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Symphony", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Musico",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Idade = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Email = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Nacionalidade = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    DateOfBirth = table.Column<DateTime>(type: "datetime(6)", nullable: true),
                    OrchestraId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Musico", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Musico_Orchestra_OrchestraId",
                        column: x => x.OrchestraId,
                        principalTable: "Orchestra",
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
                name: "IX_InstrumentModelMusicoModel_MusiciansId",
                table: "InstrumentModelMusicoModel",
                column: "MusiciansId");

            migrationBuilder.CreateIndex(
                name: "IX_InstrumentModelSymphonyModel_SymphoniesId",
                table: "InstrumentModelSymphonyModel",
                column: "SymphoniesId");

            migrationBuilder.CreateIndex(
                name: "IX_Musico_OrchestraId",
                table: "Musico",
                column: "OrchestraId");

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
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "InstrumentModelMusicoModel");

            migrationBuilder.DropTable(
                name: "InstrumentModelSymphonyModel");

            migrationBuilder.DropTable(
                name: "OrchestraSymphony");

            migrationBuilder.DropTable(
                name: "SymphonyMusician");

            migrationBuilder.DropTable(
                name: "Instrument");

            migrationBuilder.DropTable(
                name: "Musico");

            migrationBuilder.DropTable(
                name: "Symphony");

            migrationBuilder.DropTable(
                name: "Orchestra");
        }
    }
}
