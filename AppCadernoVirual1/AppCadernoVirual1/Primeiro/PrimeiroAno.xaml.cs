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
    public partial class PrimeiroAno : ContentPage
    {
        public PrimeiroAno()
        {
            InitializeComponent();
        }

        private void Voltar(object sender, EventArgs e)
        {
            Navigation.PushModalAsync(new MainPage());
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            Navigation.PushModalAsync(new MatematicaPrimeiro());
        }

        private void Button_Clicked_1(object sender, EventArgs e)
        {
            Navigation.PushModalAsync(new QuimicaPrimeiro());
        }

        private void Button_Clicked_2(object sender, EventArgs e)
        {
            Navigation.PushModalAsync(new FisicaPrimeiro());
        }

        private void Button_Clicked_3(object sender, EventArgs e)
        {
            Navigation.PushModalAsync(new GeografiaPrimeiro());
        }

        private void Button_Clicked_4(object sender, EventArgs e)
        {
            Navigation.PushModalAsync(new PortuguesPrimeiro());
        }

        private void Button_Clicked_5(object sender, EventArgs e)
        {
            Navigation.PushModalAsync(new InglesPrimeiro());
        }

        private void Button_Clicked_6(object sender, EventArgs e)
        {
            Navigation.PushModalAsync(new HistoriaPrimeiro());
        }

        private void Button_Clicked_7(object sender, EventArgs e)
        {
            Navigation.PushModalAsync(new FilosofiaPrimeiro());
        }

        private void Button_Clicked_8(object sender, EventArgs e)
        {
            Navigation.PushModalAsync(new ArtesPrimeiro());
        }

        private void Button_Clicked_9(object sender, EventArgs e)
        {
            Navigation.PushModalAsync(new BiologiaPrimeiro());
        }

        private void Button_Clicked_10(object sender, EventArgs e)
        {
            Navigation.PushModalAsync(new EdfisicaPrimeiro());
        }

        private void Button_Clicked_11(object sender, EventArgs e)
        {
            Navigation.PushModalAsync(new AnaliseSistemaPrimeiro());
        }

        private void Button_Clicked_12(object sender, EventArgs e)
        {
            Navigation.PushModalAsync(new DesignPrimeiro());
        }

        private void Button_Clicked_13(object sender, EventArgs e)
        {
            Navigation.PushModalAsync(new FundamentosInfoPrimeiro());
        }

        private void Button_Clicked_14(object sender, EventArgs e)
        {
            Navigation.PushModalAsync(new ProgAlgPrimeiro());
        }

        private void Button_Clicked_15(object sender, EventArgs e)
        {
            Navigation.PushModalAsync(new BancoDadosPrimeiro());
        }
    }
}