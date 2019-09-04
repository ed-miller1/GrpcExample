using Grpc.Core;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TestGrpcService.Models;

namespace TestGrpcService.Services
{
    public class PersonService : PersonServ.PersonServBase
    {
        private readonly ILogger<PersonService> _logger;
        private readonly grpctestdbContext dbContext;
        public PersonService(ILogger<PersonService> logger, grpctestdbContext dbContext)
        {
            _logger = logger;
            this.dbContext = dbContext;
        }

        public override async Task<Person> GetPerson(GetPersonRequest request, ServerCallContext context)
        {
            return new Person
            {
                Email = $"test{request.Id}@test.com",
                Name = $"Test{request.Id} Testerson{request.Id}",
                Id = request.Id
            };
        }

        public override async Task<Person> GetDbPerson(GetPersonRequest request, ServerCallContext context)
        {
            var dbPerson = await this.dbContext.TestPersonGrpcTbl.SingleOrDefaultAsync(x => x.Id == request.Id);
            return new Person
            {
                Email = dbPerson.Email,
                Name = dbPerson.Name,
                Id = request.Id
            };
        }
    }
}
