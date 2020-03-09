using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ONK_Delprojekt1_Backend.Migrations
{
    public partial class shiit : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Haandvaerkers",
                keyColumn: "HaandvaerkerId",
                keyValue: 1,
                column: "HVAnsaettelsedato",
                value: new DateTime(2020, 3, 9, 14, 53, 45, 691, DateTimeKind.Local).AddTicks(528));

            migrationBuilder.UpdateData(
                table: "Vaerktoejs",
                keyColumn: "VTId",
                keyValue: 1L,
                column: "VTAnskaffet",
                value: new DateTime(2020, 3, 9, 14, 53, 45, 701, DateTimeKind.Local).AddTicks(1784));

            migrationBuilder.UpdateData(
                table: "Vaerktoejskasses",
                keyColumn: "VTKId",
                keyValue: 1,
                column: "VTKAnskaffet",
                value: new DateTime(2020, 3, 9, 14, 53, 45, 702, DateTimeKind.Local).AddTicks(7564));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
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
    }
}
