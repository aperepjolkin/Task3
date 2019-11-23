using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LoansBackend.Repository;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace LoansBackend.Controllers
{
    [Produces("application/json")]
    [Route("api/Lenders")]
    public class LendersController : Controller
    {
        private readonly ILenderRepository _lenderRepository;

        public LendersController(ILenderRepository lenderRepository)
        {
            _lenderRepository = lenderRepository;
        }
        // GET: api/<controller>
        [HttpGet]
        public IEnumerable<Models.Lender> GetAll()
        {
            var lenderList = _lenderRepository.GetAll();
            return lenderList;
        }

        [HttpPost]
        public void Post([FromBody] Models.Lender lender)
        {
            _lenderRepository.Insert(lender);
            _lenderRepository.Save();
        }
    }
}
