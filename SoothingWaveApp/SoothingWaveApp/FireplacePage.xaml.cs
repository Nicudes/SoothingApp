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
            var stream = GetStreamFromFile("SoothingWaveApp.Sounds.Fireplace.mp3");
            var audio = Plugin.SimpleAudioPlayer.CrossSimpleAudioPlayer.Current;
            audio.Load(stream);
            audio.Play();

            base.OnAppearing();
        }

        private async void Back_Clicked(object sender, EventArgs e)
        {
           await Navigation.PopAsync();
        }

        Stream GetStreamFromFile(string filename)
        {
            var assembly = typeof(App).GetTypeInfo().Assembly;

            var stream = assembly.GetManifestResourceStream("yourprojectname." + filename);

            return stream;
        }
    }
}