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
    public partial class MatematicaSegundo : ContentPage
    {
        public MatematicaSegundo()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            Navigation.PushModalAsync(new SegundoAno());
        }
    }
}