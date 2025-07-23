using FinanceApp.Data;
using Microsoft.AspNetCore.Mvc;

namespace FinanceApp.Controllers
{
    public class ExpensesController : Controller
    {
        public readonly FinanceAppContext _Context;

        public ExpensesController(FinanceAppContext context)
        {
            _Context = context;
        }

        public IActionResult Index()
        {
            var expenses = _Context.Expenses.ToList();
            return View(expenses);
        }
    }
}
