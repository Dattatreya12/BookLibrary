using Microsoft.EntityFrameworkCore.Migrations;

namespace BookLibrary.Migrations
{
    public partial class dropdown : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "dropdownMonthlies",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_dropdownMonthlies", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "dropdownYearlies",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_dropdownYearlies", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "dropdownMonthlies");

            migrationBuilder.DropTable(
                name: "dropdownYearlies");
        }
    }
}
