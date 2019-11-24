using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LoansBackend.Models
{
    public class LoanViewModel
    {
        public int Id { get; set; }
        public int lenderId { get; set; }

        //public ICollection<Borrower> Borrowers { get; set; }
        public int borrowerId { get; set; }
        public string LenderName { get; set; }

        //public ICollection<Borrower> Borrowers { get; set; }
        public string BorrowerName { get; set; }

        public decimal LoanBalance { get; set; }

        public string Created { get; set; }
    }
}
