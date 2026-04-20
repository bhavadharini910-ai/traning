using System.ComponentModel;
using ExpenseTrackerApp.ViewModels;

namespace ExpenseTrackerApp.Views
{
    public partial class AddExpensePage : ContentPage
    {
        public AddExpensePage(AddExpenseViewModel vm)
        {
            InitializeComponent();
            BindingContext = vm ?? throw new ArgumentNullException(nameof(vm));
        }
    }
}

namespace ExpenseTrackerApp.ViewModels
{
    public class AddExpenseViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler? PropertyChanged;

        public AddExpenseViewModel()
        {
        }

        // Add VM properties/commands here
    }
}