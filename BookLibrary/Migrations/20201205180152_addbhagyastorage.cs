using Microsoft.EntityFrameworkCore.Migrations;

namespace BookLibrary.Migrations
{
    public partial class addbhagyastorage : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "DropdownYearlyId",
                table: "dropdownYearlies",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Bhagyastorage",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Itemname = table.Column<string>(nullable: true),
                    TotalQuantity = table.Column<int>(nullable: false),
                    amount = table.Column<int>(nullable: false),
                    Tamount = table.Column<double>(nullable: false),
                    dm = table.Column<int>(nullable: false),
                    ym = table.Column<int>(nullable: false),
                    dropdownMonthlyId = table.Column<int>(nullable: true),
                    DropdownYearlyId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Bhagyastorage", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Bhagyastorage_dropdownYearlies_DropdownYearlyId",
                        column: x => x.DropdownYearlyId,
                        principalTable: "dropdownYearlies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Bhagyastorage_dropdownMonthlies_dropdownMonthlyId",
                        column: x => x.dropdownMonthlyId,
                        principalTable: "dropdownMonthlies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_dropdownYearlies_DropdownYearlyId",
                table: "dropdownYearlies",
                column: "DropdownYearlyId");

            migrationBuilder.CreateIndex(
                name: "IX_Bhagyastorage_DropdownYearlyId",
                table: "Bhagyastorage",
                column: "DropdownYearlyId");

            migrationBuilder.CreateIndex(
                name: "IX_Bhagyastorage_dropdownMonthlyId",
                table: "Bhagyastorage",
                column: "dropdownMonthlyId");

            migrationBuilder.AddForeignKey(
                name: "FK_dropdownYearlies_dropdownYearlies_DropdownYearlyId",
                table: "dropdownYearlies",
                column: "DropdownYearlyId",
                principalTable: "dropdownYearlies",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_dropdownYearlies_dropdownYearlies_DropdownYearlyId",
                table: "dropdownYearlies");

            migrationBuilder.DropTable(
                name: "Bhagyastorage");

            migrationBuilder.DropIndex(
                name: "IX_dropdownYearlies_DropdownYearlyId",
                table: "dropdownYearlies");

            migrationBuilder.DropColumn(
                name: "DropdownYearlyId",
                table: "dropdownYearlies");
        }
    }
}
