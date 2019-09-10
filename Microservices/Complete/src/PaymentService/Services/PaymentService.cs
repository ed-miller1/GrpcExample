using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.Logging;
using PaymentService.Contexts;

namespace PaymentService.Services
{
    public class PaymentService : PaymentServices.PaymentServices.PaymentServicesBase
    {
        private readonly ILogger<PaymentService> logger;
        private readonly PaymentContext paymentContext;

        public PaymentService(ILogger<PaymentService> logger, PaymentContext paymentContext)
        {
            this.logger = logger;
            this.paymentContext = paymentContext;
        }
    }
}
