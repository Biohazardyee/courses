using System;

namespace MoonshotTestApp.Pages
{
    public partial class LoginPage : ContentPage
    {
        public LoginPage()
        {
            InitializeComponent();
        }
        private async void btnToPageRegister_Clicked(object sender, EventArgs e)
        {
            // Navigate to the RegisterPage using shell navigation
            await Shell.Current.GoToAsync("///register");
        }
        private async void btnLogin_Clicked(object sender, EventArgs e)
        {
            // For now, directly navigate to menu without authentication
            await Shell.Current.GoToAsync("///menu");
        }
    }
}