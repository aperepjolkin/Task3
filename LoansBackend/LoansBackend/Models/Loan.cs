using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LoansBackend.Models
{
    public class Loan
    {
        public int LoanId { get; set; }
        public int LenderId { get; set; }

        //public ICollection<Borrower> Borrowers { get; set; }
        public int BorrowerId { get; set; }

        public decimal LoanBalance { get; set; }

        public DateTime Created { get; set; }
    }
}
