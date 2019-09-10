using Microsoft.Extensions.Logging;
using RatingService.Contexts;

namespace RatingService.Services
{
    public class RatingService : RatingServices.RatingServices.RatingServicesBase
    {
        private readonly ILogger<RatingService> logger;
        private readonly RatingContext ratingContext;

        public RatingService(ILogger<RatingService> logger, RatingContext ratingContext)
        {
            this.logger = logger;
            this.ratingContext = ratingContext;
        }
    }
}
