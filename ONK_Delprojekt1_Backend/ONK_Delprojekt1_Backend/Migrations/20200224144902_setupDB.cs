using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ONK_Delprojekt1_Backend.Migrations
{
    public partial class setupDB : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Haandvaerkerer",
                columns: table => new
                {
                    HaandvaerkerId = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    HVAnsaettelsedato = table.Column<DateTime>(nullable: false),
                    HVEfternavn = table.Column<string>(nullable: true),
                    HVFagomraade = table.Column<string>(nullable: true),
                    HVFornavn = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Haandvaerkerer", x => x.HaandvaerkerId);
                });

            migrationBuilder.CreateTable(
                name: "Vaerktoejskasser",
                columns: table => new
                {
                    VTKId = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    VTKAnskaffet = table.Column<DateTime>(nullable: false),
                    VTKFabrikat = table.Column<string>(nullable: true),
                    VTKEjesAf = table.Column<int>(nullable: true),
                    VTKModel = table.Column<string>(nullable: true),
                    VTKSerienummer = table.Column<string>(nullable: true),
                    VTKFarve = table.Column<string>(nullable: true),
                    EjesAfNavigationHaandvaerkerId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Vaerktoejskasser", x => x.VTKId);
                    table.ForeignKey(
                        name: "FK_Vaerktoejskasser_Haandvaerkerer_EjesAfNavigationHaandvaerker~",
                        column: x => x.EjesAfNavigationHaandvaerkerId,
                        principalTable: "Haandvaerkerer",
                        principalColumn: "HaandvaerkerId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Vaerktoejer",
                columns: table => new
                {
                    VTId = table.Column<long>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    VTAnskaffet = table.Column<DateTime>(nullable: false),
                    VTFabrikat = table.Column<string>(nullable: true),
                    VTModel = table.Column<string>(nullable: true),
                    VTSerienr = table.Column<string>(nullable: true),
                    VTType = table.Column<string>(nullable: true),
                    LiggerIvtk = table.Column<int>(nullable: true),
                    LiggerIvtkNavigationVTKId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Vaerktoejer", x => x.VTId);
                    table.ForeignKey(
                        name: "FK_Vaerktoejer_Vaerktoejskasser_LiggerIvtkNavigationVTKId",
                        column: x => x.LiggerIvtkNavigationVTKId,
                        principalTable: "Vaerktoejskasser",
                        principalColumn: "VTKId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Vaerktoejer_LiggerIvtkNavigationVTKId",
                table: "Vaerktoejer",
                column: "LiggerIvtkNavigationVTKId");

            migrationBuilder.CreateIndex(
                name: "IX_Vaerktoejskasser_EjesAfNavigationHaandvaerkerId",
                table: "Vaerktoejskasser",
                column: "EjesAfNavigationHaandvaerkerId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Vaerktoejer");

            migrationBuilder.DropTable(
                name: "Vaerktoejskasser");

            migrationBuilder.DropTable(
                name: "Haandvaerkerer");
        }
    }
}
