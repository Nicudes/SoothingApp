using Plugin.SimpleAudioPlayer;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SoothingWaveApp
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ForestPage : ContentPage
    {
        public ForestPage()
        {
            InitializeComponent();
        }

        ISimpleAudioPlayer player = Plugin.SimpleAudioPlayer.CrossSimpleAudioPlayer.Current;


        void PlaySound()
        {
            player.Loop = true;
            player.Volume = 50;
            player.Load(GetStreamFromFile("ForestBird.mp3"));
            player.Play();
        }
        void StopSound()
        {
            player.Stop();
        }

        protected override void OnAppearing()
        {
            PlaySound();

            base.OnAppearing();
        }

        protected override void OnDisappearing()
        {
            player.Stop();
            base.OnDisappearing();
        }

        private async void Back_Clicked(object sender, EventArgs e)
        {
            StopSound();
            await Navigation.PopAsync();
        }

        Stream GetStreamFromFile(string filename)
        {
            var assembly = typeof(App).GetTypeInfo().Assembly;

            var stream = assembly.GetManifestResourceStream("SoothingWaveApp.Sounds." + filename);

            return stream;
        }
    }
}