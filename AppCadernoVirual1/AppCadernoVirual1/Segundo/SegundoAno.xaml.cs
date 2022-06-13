using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppCadernoVirual1.Segundo
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SegundoAno : ContentPage
    {
        public SegundoAno()
        {
            InitializeComponent();
        }

        private void Voltar2(object sender, EventArgs e)
        {
             Navigation.PushModalAsync(new MainPage());
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            Navigation.PushModalAsync(new MatematicaSegundo());
        }

        private void Button_Clicked_1(object sender, EventArgs e)
        {
            Navigation.PushModalAsync(new QuimicaSegundo());
        }

        private void Button_Clicked_2(object sender, EventArgs e)
        {
            Navigation.PushModalAsync(new FisicaSegundo());
        }

        private void Button_Clicked_3(object sender, EventArgs e)
        {
            Navigation.PushModalAsync(new GeografiaSegundo());
        }

        private void Button_Clicked_4(object sender, EventArgs e)
        {
            Navigation.PushModalAsync(new PortuguesSegundo());
        }

        private void Button_Clicked_5(object sender, EventArgs e)
        {
            Navigation.PushModalAsync(new InglesSegundo());
        }

        private void Button_Clicked_6(object sender, EventArgs e)
        {
            Navigation.PushModalAsync(new HistoriaSegundo());
        }

        private void Button_Clicked_7(object sender, EventArgs e)
        {
            Navigation.PushModalAsync(new FilosofiaSegundo());
        }

        private void Button_Clicked_8(object sender, EventArgs e)
        {
            Navigation.PushModalAsync(new SociologiaSegundo());
        }

        private void Button_Clicked_9(object sender, EventArgs e)
        {
            Navigation.PushModalAsync(new BiologiaSegundo());
        }

        private void Button_Clicked_10(object sender, EventArgs e)
        {
            Navigation.PushModalAsync(new EdfisicaSegundo());
        }

        private void Button_Clicked_11(object sender, EventArgs e)
        {
            Navigation.PushModalAsync(new EticaSegundo());
        }

        private void Button_Clicked_12(object sender, EventArgs e)
        {
            Navigation.PushModalAsync(new DesenvolvimentoSisSegundo());
        }

        private void Button_Clicked_13(object sender, EventArgs e)
        {
            Navigation.PushModalAsync(new SistemasEmbSegundo());
        }

        private void Button_Clicked_14(object sender, EventArgs e)
        {
           // Navigation.PushModalAsync(new Navigation.PushModalAsync(new ());());
        }

        private void Button_Clicked_15(object sender, EventArgs e)
        {

        }

        private void Button_Clicked_16(object sender, EventArgs e)
        {

        }
    }
}