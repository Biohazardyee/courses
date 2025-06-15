using System;

namespace MoonshotTestApp.Pages
{
    public partial class RegisterPage : ContentPage
    {
        public RegisterPage()
        {
            InitializeComponent();
        }

        private async void btnToPageLogin_Clicked(object sender, EventArgs e)
        {
            // Navigate to the LoginPage using shell navigation
            await Shell.Current.GoToAsync("///login");
        }
        private async void btnRegister_Clicked(object sender, EventArgs e)
        {
            // For now, directly navigate to menu without registration validation
            await Shell.Current.GoToAsync("///menu");
        }
    }
}