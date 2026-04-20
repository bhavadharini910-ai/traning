using System;
using System.IO;
using System.Threading.Tasks;
using SQLite;
using ExpenseTrackerApp.Models;

namespace ExpenseTrackerApp.ViewMoldels
{
    public partial class CategoriesViewModel
    {
        private static SQLiteAsyncConnection _db;

        private async Task Init()
        {
            if (_db != null) return;
            var dbPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "expenses.db3");
            _db = new SQLiteAsyncConnection(dbPath);
            await _db.CreateTableAsync<Category>();
        }

        public async Task<List<Category>> GetCategories()
        {
            await Init(); // ensure the DB is initialized (other parts of the partial class can provide Init and _db)
            return await _db.Table<Category>().ToListAsync();
        }
    }
}