using Microsoft.EntityFrameworkCore.Migrations;

namespace LoansBackend.Migrations
{
    public partial class UpdateLenderId : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Lenders_Loans_LoanId",
                table: "Lenders");

            migrationBuilder.DropIndex(
                name: "IX_Lenders_LoanId",
                table: "Lenders");

            migrationBuilder.DropColumn(
                name: "LoanId",
                table: "Lenders");

            migrationBuilder.AddColumn<int>(
                name: "LenderId",
                table: "Loans",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "LenderId",
                table: "Loans");

            migrationBuilder.AddColumn<int>(
                name: "LoanId",
                table: "Lenders",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Lenders_LoanId",
                table: "Lenders",
                column: "LoanId");

            migrationBuilder.AddForeignKey(
                name: "FK_Lenders_Loans_LoanId",
                table: "Lenders",
                column: "LoanId",
                principalTable: "Loans",
                principalColumn: "LoanId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
