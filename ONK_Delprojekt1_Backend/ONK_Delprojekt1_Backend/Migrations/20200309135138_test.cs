using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ONK_Delprojekt1_Backend.Migrations
{
    public partial class test : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Haandvaerkers",
                keyColumn: "HaandvaerkerId",
                keyValue: 1,
                column: "HVAnsaettelsedato",
                value: new DateTime(2020, 3, 9, 14, 51, 37, 194, DateTimeKind.Local).AddTicks(9888));

            migrationBuilder.UpdateData(
                table: "Vaerktoejs",
                keyColumn: "VTId",
                keyValue: 1L,
                column: "VTAnskaffet",
                value: new DateTime(2020, 3, 9, 14, 51, 37, 203, DateTimeKind.Local).AddTicks(494));

            migrationBuilder.UpdateData(
                table: "Vaerktoejskasses",
                keyColumn: "VTKId",
                keyValue: 1,
                column: "VTKAnskaffet",
                value: new DateTime(2020, 3, 9, 14, 51, 37, 204, DateTimeKind.Local).AddTicks(2142));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Haandvaerkers",
                keyColumn: "HaandvaerkerId",
                keyValue: 1,
                column: "HVAnsaettelsedato",
                value: new DateTime(2020, 3, 9, 14, 31, 20, 108, DateTimeKind.Local).AddTicks(2687));

            migrationBuilder.UpdateData(
                table: "Vaerktoejs",
                keyColumn: "VTId",
                keyValue: 1L,
                column: "VTAnskaffet",
                value: new DateTime(2020, 3, 9, 14, 31, 20, 116, DateTimeKind.Local).AddTicks(3256));

            migrationBuilder.UpdateData(
                table: "Vaerktoejskasses",
                keyColumn: "VTKId",
                keyValue: 1,
                column: "VTKAnskaffet",
                value: new DateTime(2020, 3, 9, 14, 31, 20, 117, DateTimeKind.Local).AddTicks(929));
        }
    }
}
