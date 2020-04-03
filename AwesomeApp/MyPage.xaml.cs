using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace AwesomeApp
{
    public partial class MyPage : ContentPage
    {
        public MyPage()
        {
            InitializeComponent();
        }
        public async void OnDisplayAlertButtonClicked(object sender, EventArgs e)
        {
            await DisplayAlert("Alert", "Aún no implementado", "OK");
        }
    }
}
