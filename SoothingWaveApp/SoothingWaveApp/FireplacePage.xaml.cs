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
    public partial class FireplacePage : ContentPage
    {
        public FireplacePage()
        {
            InitializeComponent();
        }

        protected override void OnAppearing()
        {
            ISimpleAudioPlayer player = Plugin.SimpleAudioPlayer.CrossSimpleAudioPlayer.Current;
            player.Loop = true;
            player.Volume = 50;
            player.Load(GetStreamFromFile("Fireplace.mp3"));
            player.Play();

            base.OnAppearing();
        }

        private async void Back_Clicked(object sender, EventArgs e)
        {
           await Navigation.PopAsync();
        }

        Stream GetStreamFromFile(string filename)
        {
            var assembly = typeof(App).GetTypeInfo().Assembly;

            var stream = assembly.GetManifestResourceStream("SoothingWaveApp." + filename);

            return stream;
        }
    }
}