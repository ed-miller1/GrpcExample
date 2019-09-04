using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TestGrpcService.Models;

namespace TestGrpcService.Repositories
{
    public class PersonRepo : IPersonRepo
    {
        private readonly grpctestdbContext dbContext;
        public PersonRepo(grpctestdbContext dbContext)
        {
            this.dbContext = dbContext;
        }
    }
}
