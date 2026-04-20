using ExpenseTrackerApp.Models;
using System.Collections.ObjectModel;

namespace ExpenseTrackerApp;

public partial class MainPage : ContentPage
{
    public ObservableCollection<Expense> Expenses { get; set; } = new();

    public MainPage()
    {
        InitializeComponent();
        expenseList.ItemsSource = Expenses;
    }

    private async void OnAddClicked(object sender, EventArgs e)
    {
        if (string.IsNullOrEmpty(titleEntry.Text) || string.IsNullOrEmpty(amountEntry.Text))
        {
            await DisplayAlert("Error", "Enter all fields", "OK");
            return;
        }

        double amount;
        if (!double.TryParse(amountEntry.Text, out amount))
        {
            await DisplayAlert("Error", "Enter valid amount", "OK");
            return;
        }

        Expenses.Add(new Expense
        {
            Title = titleEntry.Text,
            Amount = amount
        });

        titleEntry.Text = "";
        amountEntry.Text = "";
    }
}