using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LoansBackend.Context;
using LoansBackend.Models;

namespace LoansBackend.Repository
{
    public class LenderRepository : ILenderRepository
    {
        private readonly LoansContext _context;

        public LenderRepository(LoansContext context)
        {
            _context = context;
        }
        public void Delete(int lenderId)
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Lender> GetAll()
        {
            return _context.Lenders.ToList();
        }

        public Lender GetById(int lenderId)
        {
           return _context.Lenders.Find(lenderId);
        }

        public void Insert(Lender lender)
        {
            _context.Lenders.Add(lender);
        }

        public void Save()
        {
            _context.SaveChanges();
        }

        public void Update(Lender lender)
        {
            throw new NotImplementedException();
        }
    }
}
