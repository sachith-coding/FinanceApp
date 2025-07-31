using FinanceApp.Data;
using FinanceApp.Data.Services;
using FinanceApp.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace FinanceApp.Controllers
{
    public class ExpensesController : Controller
    {
        public readonly IExpenseService _expensesService;

        public ExpensesController(IExpenseService expensesService)
        {
            _expensesService = expensesService;
        }

        public async Task<IActionResult> Index()
        {
            var expenses = await _expensesService.GetAllExpenses();
            return View(expenses);
        }

        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Create(Expense expense)
        {
            if (ModelState.IsValid)
            {
                await _expensesService.AddExpense(expense); 

                return RedirectToAction("Index");
            }
            return View(expense);
        }
    }
}
