using ExpenseTrackerApp.Models;
using SQLite;

namespace ExpenseTrackerApp.Database;

public class AppDatabase
{
    private SQLiteAsyncConnection database;

    public AppDatabase(string dbPath)
    {
        database = new SQLiteAsyncConnection(dbPath);
        database.CreateTableAsync<Expense>().Wait();
    }

    public Task<List<Expense>> GetExpenses()
    {
        return database.Table<Expense>().ToListAsync();
    }

    public Task<int> SaveExpense(Expense e)
    {
        return database.InsertAsync(e);
    }
}