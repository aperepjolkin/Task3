using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using LoansBackend.Repository;
using LoansBackend.Context;
using LoansBackend.Models;
using LoansBackend.ViewModels;


// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace LoansBackend.Controllers
{
    [Produces("application/json")]
    [Route("api/[controller]/[action]")]
    public class LoansController : Controller
    {
        private readonly ILoanRepository _loanRepository;
        private readonly IMapper _mapper;

        public LoansController(ILoanRepository loanRepository, IMapper mapper) {
            _loanRepository = loanRepository;
            _mapper = mapper;
        }
        // GET: api/<controller>
        [HttpGet]
        public IEnumerable<ViewModels.LoanViewModel> Get()
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
            //return allLoans;
            return _mapper.Map<IEnumerable<LoanViewModel>>(allLoans);
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
        public ViewModels.LoanViewModel Post([FromBody] LoanViewModel loanViewModel)
        {
            var loan = _mapper.Map<Loan>(loanViewModel);
            _loanRepository.Insert(loan);
            _loanRepository.Save();
            var result = _loanRepository.GetLoanById(loan.LoanId);
            return null;
            //return result;
        }

        [HttpPost]
        public ViewModels.LoanViewModel PostLoanChanges([FromBody] Models.Loan loan)
        {
           // _loanRepository.Update(loan);
            _loanRepository.Insert(loan);
            _loanRepository.Save();
            var result = _loanRepository.GetLoanById(loan.LoanId);
            return null;
            //return result;
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
