using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LoansBackend.Models;
using LoansBackend.Context;

namespace LoansBackend.Repository
{
    public class BorrowerRepository : IBorrowerRepository
    {
        private readonly LoansContext _context;

        public BorrowerRepository(LoansContext context)
        {
            _context = context;
        }
        public void Delete(int borrowerId)
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Borrower> GetAll()
        {
           return _context.Borrowers.ToList();
        }

        public Borrower GetById(int borrowerId)
        {
            throw new NotImplementedException();
        }

        public void Insert(Borrower borrower)
        {
            _context.Borrowers.Add(borrower);
        }

        public void Save()
        {
            _context.SaveChanges();
        }

        public void Update(Borrower borrower)
        {
            throw new NotImplementedException();
        }
    }
}
