using FinanceApp.Models;
using Microsoft.EntityFrameworkCore;

namespace FinanceApp.Data
{
    public class FinanceAppContext : DbContext
    {
        // Bridge between Database and the Project

        public FinanceAppContext(DbContextOptions<FinanceAppContext> options): base(options) { }

        
        // tables of the DB
        public DbSet<Expense> Expenses { get; set; }
        public DbSet<AppUser> Users { get; set; }
    }
}
