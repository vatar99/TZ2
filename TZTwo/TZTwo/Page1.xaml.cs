using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TZTwo
{

    public partial class Page1 : ContentPage
    {
        public Page1()
        {
            InitializeComponent();
            double time = 30;
            Device.StartTimer(TimeSpan.FromSeconds(time), () =>
            {
                DisplayAlert("Время", DateTime.Now.ToString("T"), "Close");
                return true;

            });

            
        }

        private async void Next_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new MainPage());

        }
    }   }