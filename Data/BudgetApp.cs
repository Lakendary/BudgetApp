using Microsoft.EntityFrameworkCore;

namespace BudgetApp.Data
{
    public class BudgetAppContext : DbContext
    {
        public BudgetAppContext (
            DbContextOptions<BudgetAppContext> options)
            : base(options)
        {
        }

        public DbSet<BudgetApp.Models.Budget> Budget { get; set; }
    }
}