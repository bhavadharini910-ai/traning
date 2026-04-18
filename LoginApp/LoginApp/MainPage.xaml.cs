namespace LoginApp
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
        }

        private async void OnLoginClicked(object sender, EventArgs e)
        {
            string username = usernameEntry.Text;
            string password = passwordEntry.Text;

            if (username == "admin" && password == "1234")
            {
                await DisplayAlert("Success", "Login Successful!", "OK");
            }
            else
            {
                await DisplayAlert("Error", "Invalid Login", "OK");
            }
        }
    }
}
