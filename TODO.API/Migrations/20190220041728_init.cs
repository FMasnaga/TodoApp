using Microsoft.EntityFrameworkCore.Migrations;

namespace TODO.API.Migrations
{
    public partial class init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "TODOS",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Description = table.Column<string>(nullable: true),
                    Date = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TODOS", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "TODOS",
                columns: new[] { "Id", "Date", "Description" },
                values: new object[] { 1, "2020-09-09", "First thing to do" });

            migrationBuilder.InsertData(
                table: "TODOS",
                columns: new[] { "Id", "Date", "Description" },
                values: new object[] { 2, "2021-09-19", "Second thing to do" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TODOS");
        }
    }
}
