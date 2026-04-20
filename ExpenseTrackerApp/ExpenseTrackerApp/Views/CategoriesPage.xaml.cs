using ExpenseTrackerApp.ViewModels;

namespace ExpenseTrackerApp.Views;

public partial class CategoriesPage : ContentPage
{
    public CategoriesPage(CategoriesViewModel vm)
    {
        InitializeComponent();
        BindingContext = vm;
    }

    // Temporary: loads XAML at runtime if the generated method is missing
    void InitializeComponent()
    {
        Microsoft.Maui.Controls.Xaml.Extensions.LoadFromXaml(this, typeof(CategoriesPage));
    }
}