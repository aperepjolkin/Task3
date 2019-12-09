using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using LoansBackend.Repository;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace LoansBackend.Controllers
{
    [Produces("application/json")]
    [Route("api/Borrowers")]
    public class BorrowersController : Controller
    {
        private readonly IBorrowerRepository _borrowerRepository;
        private readonly IMapper _mapper;

        public BorrowersController(IBorrowerRepository borrowerRepository, IMapper mapper)
        {
            _borrowerRepository = borrowerRepository;
            _mapper = mapper;
        }
        // GET: api/<controller>
        [HttpGet]
        public IEnumerable<Models.Borrower> Get()
        {
            var borrowerList = _borrowerRepository.GetAll();
            return borrowerList;
        }

      

        // POST api/<controller>
        [HttpPost]
        public void Post([FromBody] Models.Borrower borrower)
        {
            _borrowerRepository.Insert(borrower);
            _borrowerRepository.Save();
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
