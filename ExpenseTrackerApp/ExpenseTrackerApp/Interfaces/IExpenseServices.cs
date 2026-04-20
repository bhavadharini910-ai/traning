using ExpenseTrackerApp.Models;

namespace ExpenseTrackerApp.Interfaces;

public interface IExpenseService
{
    Task<List<Category>> GetCategories();
    Task AddCategory(Category c);
    Task DeleteCategory(int id);

    Task<List<Expense>> GetExpenses();
    Task AddExpense(Expense e);
    Task DeleteExpense(int id);
}
