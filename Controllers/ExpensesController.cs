using FinanceApp.Data;
using FinanceApp.Models;
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

        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Expense expense)
        {
            if (ModelState.IsValid)
            {
                _Context.Expenses.Add(expense);
                _Context.SaveChanges();

                return RedirectToAction("Index");
            }
            return View(expense);
        }
    }
}
