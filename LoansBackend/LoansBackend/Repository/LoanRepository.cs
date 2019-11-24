using System;
using System.Collections.Generic;
using System.Linq;
using LoansBackend.Models;
using LoansBackend.Context;
using Microsoft.EntityFrameworkCore;
using MoreLinq;

namespace LoansBackend.Repository
{
    public class LoanRepository : ILoanRepository, IDisposable
    {
        private readonly LoansContext _context;
      
        public LoanRepository(LoansContext context)
        {
            _context = context;
        }

        public void Delete(int LoanId)
        {
            throw new NotImplementedException();
        }

        private bool disposed = false;
        protected virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    _context.Dispose();
                }
            }
            this.disposed = true;
        }
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);

        }
            public IEnumerable<Loan> GetAll()
        {
            return _context.Loans.ToList();
        }

        public IEnumerable<LoanViewModel> GetLoans()
        {
            var result = from loans in _context.Loans
                         from lenders in _context.Lenders
                         from borrowers in _context.Borrowers
                        where loans.BorrowerId == borrowers.Id 
                        && lenders.Id == loans.LenderId
            select new LoanViewModel
            {
                LenderName = lenders.Name,
                BorrowerName = borrowers.Name,
                LoanBalance = loans.LoanBalance,
                Created = loans.Created.ToShortDateString(),
                Id = loans.LoanId,
                lenderId = loans.LenderId,
                borrowerId = loans.BorrowerId

            };

            return result.ToList();
        }
        public LoanViewModel GetLoanById(int loanId)
        {
            var result = from loans in _context.Loans
                         from lenders in _context.Lenders
                         from borrowers in _context.Borrowers
                         where loans.BorrowerId == borrowers.Id && lenders.Id == loans.LenderId && loans.LoanId == loanId
                         select new LoanViewModel
                         {
                             LenderName = lenders.Name,
                             BorrowerName = borrowers.Name,
                             LoanBalance = loans.LoanBalance,
                             Created = loans.Created.ToShortDateString(),
                             Id = loans.LoanId,
                             lenderId = lenders.Id,
                             borrowerId = borrowers.Id

                         };

            return result.SingleOrDefault();
        }

        public Loan GetById(int LoanId)
        {
            throw new NotImplementedException();
        }

        public void Insert(Loan loan)
        {
            _context.Loans.Add(loan);
        }

        public void Save()
        {
            _context.SaveChanges();
        }

        public void Update(Loan loan)
        {
            _context.Entry(loan).State = EntityState.Modified;
        }


    }
}
