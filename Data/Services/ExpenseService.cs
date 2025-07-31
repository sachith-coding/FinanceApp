using FinanceApp.Models;
using Microsoft.EntityFrameworkCore;

namespace FinanceApp.Data.Services
{
    public class ExpenseService : IExpenseService
    {
        public readonly FinanceAppContext _Context;

        public ExpenseService(FinanceAppContext context)
        {
            _Context = context;
        }

        public async Task AddExpense(Expense expense)
        {
            _Context.Expenses.Add(expense); 
            await _Context.SaveChangesAsync();
        }

        public async Task<IEnumerable<Expense>> GetAllExpenses()
        {
            var expenses = await _Context.Expenses.ToListAsync();
            return expenses;
        }
    }
}
