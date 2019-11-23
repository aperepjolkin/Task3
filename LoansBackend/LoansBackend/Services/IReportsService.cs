using LoansBackend.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LoansBackend.Services
{
    public interface IReportsService
    {
        Lender GetMostHighestLender();
    }
}
