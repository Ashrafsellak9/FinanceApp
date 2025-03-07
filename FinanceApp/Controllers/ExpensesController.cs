using FinanceApp.Data;
using FinanceApp.Models;
using FinanceApp.Data.Service;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace FinanceApp.Controllers
{
    public class ExpensesController : Controller
    {
        private readonly IExpensesService _expensesService;

        public ExpensesController(IExpensesService expensesService)
        {
            _expensesService = expensesService;
        }

        // GET: Expenses
        public async Task<IActionResult> Index()
        {
            var expenses = await _expensesService.GetAll();
            return View(expenses);
        }

        // GET: Expenses/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Expenses/Create
        [HttpPost]
        public async Task<IActionResult> Create(Expense expense)
        {
            if (ModelState.IsValid)
            {
                await _expensesService.Add(expense);
                return RedirectToAction("Index");
            }
            return View(expense);
        }

        // GET: Expenses/Edit/5
        public async Task<IActionResult> Edit(int id)
        {
            var expense = await _expensesService.GetById(id);
            if (expense == null)
            {
                return NotFound();
            }
            return View(expense);
        }

        // POST: Expenses/Edit/5
        [HttpPost]
        public async Task<IActionResult> Edit(int id, Expense expense)
        {
            if (id != expense.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                await _expensesService.Update(expense);
                return RedirectToAction("Index");
            }
            return View(expense);
        }

        // GET: Expenses/Delete/5
        public async Task<IActionResult> Delete(int id)
        {
            var expense = await _expensesService.GetById(id);
            if (expense == null)
            {
                return NotFound();
            }
            return View(expense);
        }

        // POST: Expenses/Delete/5
        [HttpPost, ActionName("Delete")]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            await _expensesService.Delete(id);
            return RedirectToAction("Index");
        }

        // GET: Expenses/ByCategory
        public async Task<IActionResult> ByCategory(string category)
        {
            var expenses = await _expensesService.GetByCategory(category);
            return View("Index", expenses);
        }

        // GET: Expenses/Search
        public async Task<IActionResult> Search(string description)
        {
            var expenses = await _expensesService.Search(description);
            return View("Index", expenses);
        }

        // GET: Expenses/GetChart
        public IActionResult GetChart()
        {
            var data = _expensesService.GetChartData();
            return Json(data);
        }
    }
}