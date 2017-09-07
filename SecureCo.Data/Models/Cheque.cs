using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace SecureCo.Data.Models
{
    public class Cheque : BaseEntity
    {
        [Key]
        public int ChequeId { get; set; }

        [Required]
        [MaxLength(50)]
        public string FirstName { get; set; }

        [Required]
        [MaxLength(50)]
        public string LastName { get; set; }

        public decimal Amount { get; set; }

    }
}
