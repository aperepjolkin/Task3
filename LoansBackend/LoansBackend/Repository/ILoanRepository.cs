using System;
using System.Collections.Generic;
using LoansBackend.Models;

namespace LoansBackend.Repository
{
    public interface ILoanRepository: IDisposable
    {
        IEnumerable<Loan> GetAll();
        Loan GetById(int LoanId);
        void Insert(Loan loan);
        void Update(Loan loan);
        void Delete(int LoanId);
        void Save();
        void Dispose();
        IEnumerable<LoanViewModel> GetLoans();
        LoanViewModel GetLoanById(int LoanId);
    }
}
