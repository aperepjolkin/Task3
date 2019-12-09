using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace LoansBackend.Models
{
    public class Loan
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int LoanId { get; set; }
        public int LenderId { get; set; }

        public Borrower Borrower { get; set; }
        public int BorrowerId { get; set; }

        public decimal LoanBalance { get; set; }

        public DateTime Created { get; set; }
    }
}
