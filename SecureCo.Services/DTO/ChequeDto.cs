using System;

namespace SecureCo.Services.DTO
{
    public class ChequeDto
    {
        public int ChequeId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public decimal Amount { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime? DateChanged { get; set; }
    }
}
