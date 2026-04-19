
using System;
using Microsoft.Maui.Controls;
using StudentApp.Views;

namespace StudentApp.Views
{
    public partial class LoginPage : ContentPage
    {
        public LoginPage()
        {
            InitializeComponent();
        }

        private async void OnLoginClicked(object sender, EventArgs e)
        {
            if (usernameEntry.Text == "admin" && passwordEntry.Text == "1234")
            {
                await Application.Current.MainPage.Navigation.PushAsync(new MainTabbedPage());
            }
            else
            {
                await DisplayAlert("Error", "Invalid Login", "OK");
            }
        }
    }
}
