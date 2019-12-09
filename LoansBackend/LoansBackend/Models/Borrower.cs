using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LoansBackend.Models
{
    public class Borrower : Person
    {

        public ICollection<Loan> Loans { get; set; }
        public void BorromMoney() {

        }  
    }
}
