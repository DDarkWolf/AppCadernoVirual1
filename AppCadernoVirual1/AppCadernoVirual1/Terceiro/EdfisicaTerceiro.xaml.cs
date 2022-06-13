﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppCadernoVirual1.Terceiro
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class EdfisicaTerceiro : ContentPage
    {
        public EdfisicaTerceiro()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            Navigation.PushModalAsync(new TerceiroAno());
        }
    }
}