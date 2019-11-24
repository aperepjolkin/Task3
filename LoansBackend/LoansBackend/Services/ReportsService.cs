using LoansBackend.Models;
using LoansBackend.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using MoreLinq;
namespace LoansBackend.Services
{
    public class ReportsService : IReportsService
    {
        private readonly IReportsRepository _reportsRepository;
        private readonly ILenderRepository _lenderRepository;
        private readonly IBorrowerRepository _borrowerRepository;

        public ReportsService(IReportsRepository reportsRepository, 
                              ILenderRepository lenderRepository,
                              IBorrowerRepository borrowerRepository)
        {
            _reportsRepository = reportsRepository;
            _lenderRepository = lenderRepository;
            _borrowerRepository = borrowerRepository;
        }

        public Lender GetMostHighestLender() {
            var allLoans = _reportsRepository.GetAll();
            Loan maxLoan = allLoans.MaxBy(loan => loan.LoanBalance).FirstOrDefault();
            Lender maxLender = new Lender() {
                Name = "",
                Balance = 0
            };
            if (maxLoan != null) {
                maxLender = _lenderRepository.GetById(maxLoan.LenderId);
                maxLender.Balance = maxLoan.LoanBalance;
            }
           
            
            return maxLender;
        }
        public Borrower GetMostHighestBorrower()
        {
            var allLoans = _reportsRepository.GetAll();
            Loan maxLoan = allLoans.MaxBy(loan => loan.LoanBalance).FirstOrDefault();
            Borrower maxBorrower = new Borrower()
            {
                Name = "",
                Balance = 0
            };
            if (maxLoan != null)
            {
                maxBorrower = _borrowerRepository.GetById(maxLoan.BorrowerId);
                maxBorrower.Balance = maxLoan.LoanBalance;
            }


            return maxBorrower;
        }

        public decimal GetAverageLoan()
        {
            var allLoans = _reportsRepository.GetAll();
            var allLenders = _lenderRepository.GetAll();
            var result = from loan in allLoans
                         from lenders in allLenders
                         where loan.LenderId == lenders.Id
                         select loan;
            decimal averageLoan = result.Average(x => x.LoanBalance);
            return averageLoan;
        }
    }
}
