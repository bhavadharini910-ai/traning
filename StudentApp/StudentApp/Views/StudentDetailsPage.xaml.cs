namespace StudentApp.Views;

using StudentApp.ViewModels;

public partial class StudentDetailsPage : ContentPage
{
    public StudentDetailsPage()
    {
        InitializeComponent();
        BindingContext = new StudentViewModel();
    }
}