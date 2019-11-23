using System;
using System.Collections.Generic;
using LoansBackend.Models;

namespace LoansBackend.Repository
{
    public interface IBorrowerRepository: IDisposable
    {
        IEnumerable<Borrower> GetAll();
        Borrower GetById(int borrowerId);
        void Insert(Borrower borrower);
        void Update(Borrower borrower);
        void Delete(int borrowerId);
        void Save();
        void Dispose();
    }
}
