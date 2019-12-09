using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LoansBackend.ViewModels
{
    public class LoanViewModel
    {
      
        public int LenderId { get; set; }

        //public ICollection<Borrower> Borrowers { get; set; }
        public int BorrowerId { get; set; }
        public string LenderName { get; set; }

        //public ICollection<Borrower> Borrowers { get; set; }
        public string BorrowerName { get; set; }

        public decimal LoanBalance { get; set; }

        public string Created { get; set; }
    }
}
