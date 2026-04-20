using ExpenseTrackerApp.Interfaces;
using ExpenseTrackerApp.Models;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExpenseTrackerApp.Services
{
    public class ExpenseService : IExpenseService
    {
        private List<Category> categories = new List<Category>();
        private List<Expense> expenses = new List<Expense>();

        public ExpenseService()
        {
            categories.Add(new Category { Id = 1, Name = "Food", Icon = "🍔" });
            categories.Add(new Category { Id = 2, Name = "Transport", Icon = "🚌" });
        }

        public Task<List<Category>> GetCategories()
        {
            return Task.FromResult(categories);
        }

        public Task AddCategory(Category c)
        {
            c.Id = categories.Count + 1;
            categories.Add(c);
            return Task.CompletedTask;
        }

        public Task DeleteCategory(int id)
        {
            var item = categories.FirstOrDefault(x => x.Id == id);
            if (item != null)
                categories.Remove(item);

            return Task.CompletedTask;
        }

        public Task<List<Expense>> GetExpenses()
        {
            return Task.FromResult(expenses);
        }

        public Task AddExpense(Expense e)
        {
            e.Id = expenses.Count + 1;
            expenses.Add(e);
            return Task.CompletedTask;
        }

        public Task DeleteExpense(int id)
        {
            var item = expenses.FirstOrDefault(x => x.Id == id);
            if (item != null)
                expenses.Remove(item);

            return Task.CompletedTask;
        }
    }
}