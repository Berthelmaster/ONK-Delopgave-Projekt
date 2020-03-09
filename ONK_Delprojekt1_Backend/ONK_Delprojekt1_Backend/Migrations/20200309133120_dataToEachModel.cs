using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ONK_Delprojekt1_Backend.Migrations
{
    public partial class dataToEachModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Haandvaerkers",
                keyColumn: "HaandvaerkerId",
                keyValue: 1,
                column: "HVAnsaettelsedato",
                value: new DateTime(2020, 3, 9, 14, 31, 20, 108, DateTimeKind.Local).AddTicks(2687));

            migrationBuilder.InsertData(
                table: "Vaerktoejs",
                columns: new[] { "VTId", "LiggerIvtk", "LiggerIvtkNavigationVTKId", "VTAnskaffet", "VTFabrikat", "VTModel", "VTSerienr", "VTType" },
                values: new object[] { 1L, null, null, new DateTime(2020, 3, 9, 14, 31, 20, 116, DateTimeKind.Local).AddTicks(3256), "Test fabrikat", "QC521", "2011064688", "Skruetrækker" });

            migrationBuilder.InsertData(
                table: "Vaerktoejskasses",
                columns: new[] { "VTKId", "EjesAfNavigationHaandvaerkerId", "VTKAnskaffet", "VTKEjesAf", "VTKFabrikat", "VTKFarve", "VTKModel", "VTKSerienummer" },
                values: new object[] { 1, null, new DateTime(2020, 3, 9, 14, 31, 20, 117, DateTimeKind.Local).AddTicks(929), null, "Test fabrikat", "Blaa", "AN521", "2019064688" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Vaerktoejs",
                keyColumn: "VTId",
                keyValue: 1L);

            migrationBuilder.DeleteData(
                table: "Vaerktoejskasses",
                keyColumn: "VTKId",
                keyValue: 1);

            migrationBuilder.UpdateData(
                table: "Haandvaerkers",
                keyColumn: "HaandvaerkerId",
                keyValue: 1,
                column: "HVAnsaettelsedato",
                value: new DateTime(2020, 3, 9, 10, 55, 22, 472, DateTimeKind.Local).AddTicks(2089));
        }
    }
}
