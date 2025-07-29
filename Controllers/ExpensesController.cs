using FinanceApp.Data;
using FinanceApp.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace FinanceApp.Controllers
{
    public class ExpensesController : Controller
    {
        public readonly FinanceAppContext _Context;

        public ExpensesController(FinanceAppContext context)
        {
            _Context = context;
        }

        public async Task<IActionResult> Index()
        {
            var expenses = await _Context.Expenses.ToListAsync();
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
                _Context.Expenses.Add(expense);
                await _Context.SaveChangesAsync();

                return RedirectToAction("Index");
            }
            return View(expense);
        }
    }
}
