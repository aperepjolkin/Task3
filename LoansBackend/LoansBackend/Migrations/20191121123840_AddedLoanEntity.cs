using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace LoansBackend.Migrations
{
    public partial class AddedLoanEntity : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "LoanId",
                table: "Lenders",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "LoanId",
                table: "Borrowers",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Loans",
                columns: table => new
                {
                    LoanId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    LoanBalance = table.Column<decimal>(nullable: false),
                    Created = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Loans", x => x.LoanId);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Lenders_LoanId",
                table: "Lenders",
                column: "LoanId");

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

            migrationBuilder.AddForeignKey(
                name: "FK_Lenders_Loans_LoanId",
                table: "Lenders",
                column: "LoanId",
                principalTable: "Loans",
                principalColumn: "LoanId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Borrowers_Loans_LoanId",
                table: "Borrowers");

            migrationBuilder.DropForeignKey(
                name: "FK_Lenders_Loans_LoanId",
                table: "Lenders");

            migrationBuilder.DropTable(
                name: "Loans");

            migrationBuilder.DropIndex(
                name: "IX_Lenders_LoanId",
                table: "Lenders");

            migrationBuilder.DropIndex(
                name: "IX_Borrowers_LoanId",
                table: "Borrowers");

            migrationBuilder.DropColumn(
                name: "LoanId",
                table: "Lenders");

            migrationBuilder.DropColumn(
                name: "LoanId",
                table: "Borrowers");
        }
    }
}
