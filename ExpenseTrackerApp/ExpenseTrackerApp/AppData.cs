using ExpenseTrackerApp.Models;
using System.Collections.ObjectModel;

namespace ExpenseTrackerApp;

public static class AppData
{



    // Keep only one Expenses property. ObservableCollection is useful for UI binding.
    public static ObservableCollection<Expense> Expenses { get; set; } = new();

    public static ObservableCollection<Category> Categories { get; set; } = new()
    {
        new Category { Name = "Food" },
        new Category { Name = "Travel" },
        new Category { Name = "Shopping" }
    };
}