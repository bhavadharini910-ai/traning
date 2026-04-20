using SQLite;

namespace ExpenseTrackerApp.Models;

public class Expense
{
    [PrimaryKey, AutoIncrement]
    public int Id { get; set; }

    public string Title { get; set; }
    public double Amount { get; set; }
    public string Category { get; set; }
}