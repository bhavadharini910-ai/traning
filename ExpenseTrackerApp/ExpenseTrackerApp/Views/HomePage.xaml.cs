using System.Collections.ObjectModel;
using System.Linq;
using ExpenseTrackerApp.Models;

namespace ExpenseTrackerApp.Views;

public partial class HomePage : ContentPage
{
    public HomePage()
    {
        InitializeComponent();
    }

    protected override void OnAppearing()
    {
        base.OnAppearing();

        // Ensure AppData exists
        if (AppData.Expenses == null)
            AppData.Expenses = new ObservableCollection<Expense>();

        var expenses = AppData.Expenses;

        totalCountLabel.Text = $"Total Expenses: {expenses.Count}";

        double total = expenses.Sum(x => x.Amount);
        totalAmountLabel.Text = $"Total Amount: ₹{total}";
    }
}
