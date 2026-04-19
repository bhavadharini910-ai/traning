using Microsoft.Maui.Controls;
using StudentApp.ViewModels;

namespace StudentApp.Views
{
    public partial class MarklistPage : ContentPage
    {
        public MarklistPage()
        {
            InitializeComponent();
            BindingContext = new StudentViewModel();
        }
    }
}