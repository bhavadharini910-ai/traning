using Microsoft.Maui.Controls;
using StudentApp.Views;

namespace StudentApp
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            // ✅ MainPage should be set here
            MainPage = new NavigationPage(new LoginPage());
        }
    }
}