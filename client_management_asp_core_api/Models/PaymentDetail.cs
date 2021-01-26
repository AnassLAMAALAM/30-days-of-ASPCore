using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace client_management_asp_core_api.Models
{
    public class PaymentDetail
    {
        [Key]
        public int paymentDetailId { get; set; }

        [Required]
        [Column(TypeName = "nvarchar(100)")]
        public string cardOwnerName { get; set; }
        [Required]
        [Column(TypeName = "nvarchar(16)")]
        public string CardNmber { get; set; }
        [Required]
        [Column(TypeName = "nvarchar(5)")]
        public string expirationDate { get; set; }
        [Required]

        [Column(TypeName = "nvarchar(3)")]
        public string securityCode { get; set; }

        public Client Client { get; set; }

    }
}
