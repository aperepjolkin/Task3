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
        private readonly ILenderRepository _landerRepository;

        public ReportsService(IReportsRepository reportsRepository, ILenderRepository lenderRepository)
        {
            _reportsRepository = reportsRepository;
            _landerRepository = lenderRepository;
        }

        public Lender GetMostHighestLender() {
            var allLoans = _reportsRepository.GetAll();
            Loan maxLoan = allLoans.MaxBy(loan => loan.LoanBalance).FirstOrDefault();
            Lender maxLender = new Lender() {
                Name = "",
                Balance = 0
            };
            if (maxLoan != null) {
                maxLender = _landerRepository.GetById(maxLoan.LenderId);
                maxLender.Balance = maxLoan.LoanBalance;
            }
           
            
            return maxLender;
        }
    }
}
