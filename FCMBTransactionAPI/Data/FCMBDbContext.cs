using FCMBTransactionAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace FCMBTransactionAPI.Data
{
    public class FCMBDbContext : DbContext
    {
        public FCMBDbContext(DbContextOptions<FCMBDbContext> options) : base(options)
        {

        }

        public DbSet<DoTransfer> DoTransfer { get; set; }
        public DbSet<BuyAirtime> BuyAirtime { get; set; }

        
    }
}
