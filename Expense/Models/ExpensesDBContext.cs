using Microsoft.EntityFrameworkCore;

namespace Expense.Models
{
    public class ExpensesDBContext : DbContext
    {
        public DbSet<Expenses> Expenses { get; set; }

        public ExpensesDBContext(DbContextOptions<ExpensesDBContext>options)
            : base(options)
        {
            
        }
    }
}
