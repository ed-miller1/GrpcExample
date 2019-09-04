using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PersonWebAPITest.Models;

namespace PersonWebAPITest.Controllers
{
    [ApiController]
    [Produces("application/json")]
    [Route("person")]
    public class PersonController : Controller
    {
        private readonly grpctestdbContext dbContext;
        public PersonController(grpctestdbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Person>> GetPerson(int id)
        {
            return new OkObjectResult(new Person
            {
                Name = $"Test{id} Testerson{id}",
                Email = $"test{id}@test.com",
                Id = id
            });
        }

        [HttpGet("db/{id}")]
        public async Task<ActionResult<TestPersonRestTbl>> GetDbPerson(int id)
        {
            return new OkObjectResult(await dbContext.TestPersonRestTbl.SingleOrDefaultAsync(x => x.Id == id));
        }
    }
}