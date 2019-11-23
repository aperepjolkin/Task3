using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LoansBackend.Context;
using LoansBackend.Models;

namespace LoansBackend.Repository
{
    public class ReportsRepository : IReportsRepository
    {
        private readonly LoansContext _context;

        public ReportsRepository(LoansContext context)
        {
            _context = context;
        }

        public IEnumerable<Loan> GetAll()
        {
           return _context.Loans.ToList();
        }
    }
}
