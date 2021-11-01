using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace FKR32_assistant_mobile
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CalculatorPage : ContentPage
    {
        public CalculatorPage()
        {
            InitializeComponent();
        }

        private void Add_Clicked(object sender, EventArgs e)
        {
            ResultLabel.Text = (Convert.ToInt32(ValueAEntry.Text) + Convert.ToInt32
            (ValueBEntry.Text)).ToString();
        }
        private void Multiply_Clicked(object sender, EventArgs e)
        {
            ResultLabel.Text = (Convert.ToInt32(ValueAEntry.Text) * Convert.ToInt32
            (ValueBEntry.Text)).ToString();
        }
    }
}