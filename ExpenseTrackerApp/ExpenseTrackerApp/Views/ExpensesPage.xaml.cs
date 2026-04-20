using System.ComponentModel;
using ExpenseTrackerApp.ViewModels;

namespace ExpenseTrackerApp.Views
{
    public partial class ExpensesPage : ContentPage
    {
        public ExpensesPage(ExpensesViewModel vm)
        {
            InitializeComponent();
            BindingContext = vm;
        }
    }
}

namespace ExpenseTrackerApp.ViewModels
{
    public class ExpensesViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        public ExpensesViewModel()
        {
            // initialize properties/commands here
        }

        protected void OnPropertyChanged(string propertyName) =>
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }
}