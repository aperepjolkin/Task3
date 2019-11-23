using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MessageBoardBackend.Controllers
{
    [Produces("application/json")]
    [Route("api/Messages")]
    public class MessagesController : Controller
    {
        // GET: api/<controller>
        [HttpGet]
        public IEnumerable<Models.Message> Get()
        {
            return new Models.Message[] {
                new Models.Message {
                    Owner = "John",
                    Text = "hello"
                },
                new Models.Message {
                    Owner = "Tim",
                    Text = "Hi"
                },
                new Models.Message {
                    Owner = "Aleks",
                    Text = "Hello"
                }
            };
        }

    }
}
