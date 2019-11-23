using LoansBackend.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LoansBackend.Repository
{
    public interface IReportsRepository
    {
        IEnumerable<Loan> GetAll();
    }
}
