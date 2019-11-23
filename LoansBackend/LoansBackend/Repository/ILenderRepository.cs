using LoansBackend.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LoansBackend.Repository
{
    public interface ILenderRepository
    {
        IEnumerable<Lender> GetAll();
        Lender GetById(int lenderId);
        void Insert(Lender lender);
        void Update(Lender lender);
        void Delete(int lenderId);
        void Save();
        void Dispose();
    }
}
