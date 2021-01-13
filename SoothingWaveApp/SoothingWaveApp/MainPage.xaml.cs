using System;
using Plugin.SimpleAudioPlayer;
using System.IO;
using System.Reflection;
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


        ISimpleAudioPlayer player = Plugin.SimpleAudioPlayer.CrossSimpleAudioPlayer.Current;


        void PlaySound()
        {
            player.Loop = true;
            player.Volume = 0.1;
            player.Load(GetStreamFromFile("BirdSplash.mp3"));
            player.Play();
        }

        protected override void OnDisappearing()
        {
            player.Stop();
            base.OnDisappearing();
        }

        protected override void OnAppearing()
        {
            PlaySound();

            base.OnAppearing();
        }

        Stream GetStreamFromFile(string filename)
        {
            var assembly = typeof(App).GetTypeInfo().Assembly;

            var stream = assembly.GetManifestResourceStream("SoothingWaveApp.Sounds." + filename);

            return stream;
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
