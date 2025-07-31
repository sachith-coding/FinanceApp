using FinanceApp.Models;

namespace FinanceApp.Data.Services
{
    public interface IExpenseService
    {
        Task<IEnumerable<Expense>> GetAllExpenses(); 
        Task AddExpense(Expense expense);
    }
}
