using System;

namespace SecureCo.WebApi.Models.Cheque
{
    public class ChequeRequest
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public decimal Amount { get; set; }

    }
}