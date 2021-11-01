using FKR32_assistant_mobile.Service;
using System;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace FKR32_assistant_mobile
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AuthorizationPage : ContentPage
    {
        public AuthorizationPage()
        {
            InitializeComponent();
        }

        private void AddAuthorization_Clicked(object sender, EventArgs e)
        {
            string addName = NameEntry.Text;

            AuthService authService = new AuthService();
            ResultAuthorizationLabel.Text = authService.Authorization(addName); 
        }


    }
}