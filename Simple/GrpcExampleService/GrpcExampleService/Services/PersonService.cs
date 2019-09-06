using System.Threading.Tasks;
using Grpc.Core;
using Microsoft.Extensions.Logging;
using TestGrpcService;

namespace GrpcExampleService.Services
{
    public class PersonService : PersonServ.PersonServBase
    {
        private readonly ILogger<PersonService> logger;
        public PersonService(ILogger<PersonService> logger)
        {
            this.logger = logger;
        }

        public override async Task<Person> GetPerson(GetPersonRequest request, ServerCallContext context)
        {
            return new Person
            {
                Email = $"test{request.Id}@test.com",
                Id = request.Id,
                Name = $"Test{request.Id} Testerson{request.Id}"
            };
        }
    }
}
