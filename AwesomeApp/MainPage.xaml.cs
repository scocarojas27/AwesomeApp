using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace AwesomeApp
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

        }
        public async void OnDisplayAlertButtonClicked(object sender, EventArgs e)
        {
            await DisplayAlert("Alert", "This is an alert.", "OK");
        }
        public async void GoToNewPage1(object sender, EventArgs e)
        {
            await DisplayAlert("Alert", "Pasará a ver la información del producto detallada", "OK");
            await Navigation.PushAsync(new MyPage());
        }
        public async void GoToNewPage2(object sender, EventArgs e)
        {
            await DisplayAlert("Alert", "Pasará a ver la información del producto detallada", "OK");
            await Navigation.PushAsync(new Page1());
        }
        /*protected override void OnAppearing()
        {
            base.OnAppearing();

            entry.Text = (Application.Current as App).DisplayText;
        }*/

        /*void OnEntryCompleted(object sender, EventArgs e)
        {
            (Application.Current as App).DisplayText = entry.Text;
        }*/
    }
}
