using FinanceApp.Models;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FinanceApp.Data.Service
{
    public interface IExpensesService
    {
        Task<IEnumerable<Expense>> GetAll();
        Task Add(Expense expense);
        Task<Expense> GetById(int id);
        Task Update(Expense expense);
        Task Delete(int id);
        IQueryable GetChartData();
        Task<IEnumerable<Expense>> GetByCategory(string category);
        Task<IEnumerable<Expense>> Search(string description);
    }
}