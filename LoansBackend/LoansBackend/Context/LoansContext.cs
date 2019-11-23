using Microsoft.EntityFrameworkCore;
using LoansBackend.Models;
namespace LoansBackend.Context
{
    public class LoansContext : DbContext
    {
        public LoansContext(DbContextOptions<LoansContext> options)
            : base(options)
        {
        }

        public DbSet<Borrower> Borrowers { get; set; }
        public DbSet<Lender> Lenders { get; set; }

        public DbSet<Loan> Loans { get; set; }
    }
}
