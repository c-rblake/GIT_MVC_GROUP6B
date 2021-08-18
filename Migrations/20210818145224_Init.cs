using Microsoft.EntityFrameworkCore.Migrations;

namespace GIT_MVC_GROUP6B.Migrations
{
    public partial class Init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Thing1",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Age = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Thing1", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Thing1",
                columns: new[] { "Id", "Age", "Name" },
                values: new object[,]
                {
                    { 1, 1, "A" },
                    { 2, 2, "B" },
                    { 3, 3, "C" },
                    { 4, 4, "D" },
                    { 5, 5, "E" },
                    { 6, 6, "F" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Thing1");
        }
    }
}
