using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace FCMBTransactionAPI.Models
{
    [Keyless]
    public class BuyAirtime
    {
        [Required]
        public string SourceAccount { get; set; }
        [Required]
        public string NetworkProvider { get; set; }
        [Required]
        public int Amount { get; set; }
        [Required]
        public string PhoneNumber { get; set; }

    }
}
