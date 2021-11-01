using System;
using Xamarin.Forms;

namespace FKR32_assistant_mobile
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void OpenCalculatorPage_OnTapped(object sender, EventArgs e)
        {
            Application.Current.MainPage.Navigation.PushModalAsync(new NavigationPage(new CalculatorPage()));
        }

        private void OpenAuthorizationPage_OnTapped(object sender, EventArgs e)
        {
            Application.Current.MainPage.Navigation.PushModalAsync(new NavigationPage(new AuthorizationPage()));
        }
    }
}
