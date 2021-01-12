﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SoothingWaveApp
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class RainPage : ContentPage
    {
        public RainPage()
        {
            InitializeComponent();
        }
        private async void Back_Clicked(object sender, EventArgs e)
        {
            await Navigation.PopAsync();
        }
    }
}