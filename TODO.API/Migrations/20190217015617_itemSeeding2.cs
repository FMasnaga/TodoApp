using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TODO.API.Migrations
{
    public partial class itemSeeding2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "TODOS",
                columns: new[] { "Id", "Description", "Time" },
                values: new object[] { 2, "Second thing to do", new DateTime(2018, 8, 8, 0, 0, 0, 0, DateTimeKind.Unspecified) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "TODOS",
                keyColumn: "Id",
                keyValue: 2);
        }
    }
}
