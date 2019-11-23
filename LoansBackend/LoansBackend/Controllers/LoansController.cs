using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using LoansBackend.Repository;
using LoansBackend.Context;
using LoansBackend.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace LoansBackend.Controllers
{
    [Produces("application/json")]
    [Route("api/Loans")]
    public class LoansController : Controller
    {
        private readonly ILoanRepository _loanRepository;
       
        public LoansController(ILoanRepository loanRepository) {
            _loanRepository = loanRepository;
        }
        // GET: api/<controller>
        [HttpGet]
        public IEnumerable<Models.LoanViewModel> Get()
        {
            //return new Models.Loan[] {
            //    new Models.Loan {
            //        BorrowerId = 1,
            //        LenderId = 2,
            //        LoanBalance = 20
            //    },
            //    new Models.Loan {
            //        BorrowerId = 2,
            //        LenderId = 2,
            //        LoanBalance = 30
            //    }

            //};
            var allLoans = _loanRepository.GetLoans();
            return allLoans;
            //return _loanRepository.GetAll();
        }

        // GET api/<controller>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<controller>
        [HttpPost]
        public Models.LoanViewModel Post([FromBody] Models.Loan loan)
        {
            _loanRepository.Insert(loan);
            _loanRepository.Save();
            var result = _loanRepository.GetLoanById(loan.LoanId);
            return result;
        }

        // PUT api/<controller>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/<controller>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
