using Microsoft.EntityFrameworkCore.Migrations;

namespace LoansBackend.Migrations
{
    public partial class UpdatedLoanModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Borrowers_Loans_LoanId",
                table: "Borrowers");

            migrationBuilder.DropIndex(
                name: "IX_Borrowers_LoanId",
                table: "Borrowers");

            migrationBuilder.DropColumn(
                name: "LoanId",
                table: "Borrowers");

            migrationBuilder.AddColumn<int>(
                name: "BorrowerId",
                table: "Loans",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "BorrowerId",
                table: "Loans");

            migrationBuilder.AddColumn<int>(
                name: "LoanId",
                table: "Borrowers",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Borrowers_LoanId",
                table: "Borrowers",
                column: "LoanId");

            migrationBuilder.AddForeignKey(
                name: "FK_Borrowers_Loans_LoanId",
                table: "Borrowers",
                column: "LoanId",
                principalTable: "Loans",
                principalColumn: "LoanId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
