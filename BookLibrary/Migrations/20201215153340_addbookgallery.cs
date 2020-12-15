using Microsoft.EntityFrameworkCore.Migrations;

namespace BookLibrary.Migrations
{
    public partial class addbookgallery : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_dropdownYearlies_dropdownYearlies_DropdownYearlyId",
                table: "dropdownYearlies");

            migrationBuilder.DropIndex(
                name: "IX_dropdownYearlies_DropdownYearlyId",
                table: "dropdownYearlies");

            migrationBuilder.DropColumn(
                name: "DropdownYearlyId",
                table: "dropdownYearlies");

            migrationBuilder.AddColumn<string>(
                name: "CoverImageUrl",
                table: "Books",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "bookGalleries",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BookId = table.Column<int>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    URL = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_bookGalleries", x => x.Id);
                    table.ForeignKey(
                        name: "FK_bookGalleries_Books_BookId",
                        column: x => x.BookId,
                        principalTable: "Books",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_bookGalleries_BookId",
                table: "bookGalleries",
                column: "BookId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "bookGalleries");

            migrationBuilder.DropColumn(
                name: "CoverImageUrl",
                table: "Books");

            migrationBuilder.AddColumn<int>(
                name: "DropdownYearlyId",
                table: "dropdownYearlies",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_dropdownYearlies_DropdownYearlyId",
                table: "dropdownYearlies",
                column: "DropdownYearlyId");

            migrationBuilder.AddForeignKey(
                name: "FK_dropdownYearlies_dropdownYearlies_DropdownYearlyId",
                table: "dropdownYearlies",
                column: "DropdownYearlyId",
                principalTable: "dropdownYearlies",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
