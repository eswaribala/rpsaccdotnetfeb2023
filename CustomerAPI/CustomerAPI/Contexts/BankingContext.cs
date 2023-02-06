using Microsoft.EntityFrameworkCore;

namespace CustomerAPI.Contexts
{
    public class BankingContext:DbContext
    {
        public BankingContext(DbContextOptions<BankingContext> options) : 
            base(options)
        {
            this.Database.EnsureCreated();
        }

    }
}
