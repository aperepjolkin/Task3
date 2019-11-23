using Microsoft.EntityFrameworkCore.Migrations;

namespace LoansBackend.Migrations
{
    public partial class AddedBalace : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<decimal>(
                name: "Balance",
                table: "Lenders",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "Balance",
                table: "Borrowers",
                nullable: false,
                defaultValue: 0m);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Balance",
                table: "Lenders");

            migrationBuilder.DropColumn(
                name: "Balance",
                table: "Borrowers");
        }
    }
}
