using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppCadernoVirual1.Terceiro
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class TerceiroAno : ContentPage
    {
        public TerceiroAno()
        {
            InitializeComponent();
        }

        private void Voltar3(object sender, EventArgs e)
        {
            Navigation.PushModalAsync(new MainPage());
        }

        private void btn_mat_terceiro(object sender, EventArgs e)
        {
            Navigation.PushModalAsync(new MatematicaTerceiro());
        }

        private void btn_qui_terceiro(object sender, EventArgs e)
        {
            Navigation.PushModalAsync(new QuimicaTerceiro());
        }

        private void btn_fis_terceiro(object sender, EventArgs e)
        {
            Navigation.PushModalAsync(new FisicaTerceiro());
        }

        private void btn_geo_terceiro(object sender, EventArgs e)
        {
            Navigation.PushModalAsync(new GeografiaTerceiro());
        }

        private void btn_port_terceiro(object sender, EventArgs e)
        {
            Navigation.PushModalAsync(new PortuguesTerceiro());
        }

        private void btn_ing_terceiro(object sender, EventArgs e)
        {
            Navigation.PushModalAsync(new InglesTerceiro());
        }

        private void btn_his_terceiro(object sender, EventArgs e)
        {
            Navigation.PushModalAsync(new HistoriaTerceiro());
        }

        private void btn_fil_terceiro(object sender, EventArgs e)
        {
            Navigation.PushModalAsync(new FilosofiaTerceiro());
        }

        private void btn_soc_terceiro(object sender, EventArgs e)
        {
            Navigation.PushModalAsync(new SociologiaTerceiro());
        }

        private void btn_bio_terceiro(object sender, EventArgs e)
        {
            Navigation.PushModalAsync(new BiologiaTerceiro());
        }

        private void btn_edfis_terceiro(object sender, EventArgs e)
        {
            Navigation.PushModalAsync(new EdfisicaTerceiro());
        }

        private void btn_testesoftware_terceiro(object sender, EventArgs e)
        {
            Navigation.PushModalAsync(new TesteDeSoftwareTerceiro());
        }

        private void btn_internet_terceiro(object sender, EventArgs e)
        {
            Navigation.PushModalAsync(new InternetTerceiro());
        }

        private void btn_web3_terceiro(object sender, EventArgs e)
        {
            Navigation.PushModalAsync(new Web3Terceiro());
        }

        private void btn_mob2_terceiro(object sender, EventArgs e)
        {
            Navigation.PushModalAsync(new Mobile2Terceiro());
        }

        private void btn_tcc_terceiro(object sender, EventArgs e)
        {
            Navigation.PushModalAsync(new TccTerceiro());
        }
    }
}