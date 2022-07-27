using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace FCMBTransactionAPI.Models
{
    [Keyless]
    public class DoTransfer
    {
        [Required]
        public int Amount { get; set; }
        [Required]
        public string SourceAccount { get; set; }
        [Required]
        public string DestinationAccount { get; set; }
    }
}
