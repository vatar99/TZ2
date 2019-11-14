using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace TZTwo
{
   
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            double time = 30;
            Device.StartTimer(TimeSpan.FromSeconds(time), () =>
           {
               DisplayAlert("Время", DateTime.Now.ToString("T"), "Close");
               return true;
           });
        }


        private async void Button1_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Page1());

        }

        private async void Button2_Clicked(object sender, EventArgs e)
        {
            await DisplayAlert("Методы что использовались", "OnSleep OnStart OnResume", "Закрыть");
        }
    }
}
