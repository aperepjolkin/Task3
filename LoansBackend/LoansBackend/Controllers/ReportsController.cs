using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LoansBackend.Services;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace LoansBackend.Controllers
{
    [Produces("application/json")]
    [Route("api/[controller]/[action]")]
    public class ReportsController : Controller
    {

        private readonly IReportsService _reportsService;

        public ReportsController(IReportsService reportsService)
        {
            _reportsService = reportsService;
        }
        

        // GET: api/<controller>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        [HttpGet]
        public Models.Lender MostHigherLender()
        {
            var highestLender = _reportsService.GetMostHighestLender();
            return highestLender;

        }

        [HttpGet]
        public Models.Borrower MostHigherBorrower()
        {
            var highestBorrower = _reportsService.GetMostHighestBorrower();
            return highestBorrower;

        }
        [HttpGet]
        public decimal AverageLoan()
        {
            var averageLoan = _reportsService.GetAverageLoan();
            return averageLoan;

        }
        // POST api/<controller>
        [HttpPost]
        public void Post([FromBody]string value)
        {
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
