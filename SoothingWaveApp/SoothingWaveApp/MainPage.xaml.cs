using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace SoothingWaveApp
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void Forest_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new ForestPage());
        }

        private async void Snow_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new SnowPage());

        }

        private async void Ocean_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new OceanPage());

        }

        private async void Sunset_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new SunsetPage());

        }

        private async void Marketplace_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new MarketplacePage());

        }

        private async void Rain_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new RainPage());

        }

        private async void Fireplace_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new FireplacePage());

        }
    }
}
