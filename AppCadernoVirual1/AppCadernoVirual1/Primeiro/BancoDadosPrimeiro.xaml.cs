using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppCadernoVirual1.Primeiro
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class BancoDadosPrimeiro : ContentPage
    {
        public BancoDadosPrimeiro()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            Navigation.PushModalAsync(new PrimeiroAno());
        }
    }
}