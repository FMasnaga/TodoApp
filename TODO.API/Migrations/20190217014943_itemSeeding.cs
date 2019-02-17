using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TODO.API.Migrations
{
    public partial class itemSeeding : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "TODOS",
                columns: new[] { "Id", "Description", "Time" },
                values: new object[] { 1, "First thing to do", new DateTime(2015, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "TODOS",
                keyColumn: "Id",
                keyValue: 1);
        }
    }
}
