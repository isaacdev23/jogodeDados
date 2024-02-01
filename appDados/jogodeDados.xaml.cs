using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace appDados
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class jogodeDados : ContentPage
    {
        public jogodeDados()
        {
            InitializeComponent();
            Random r = new Random();
            int n = r.Next(1, 6);
            if (n == 1)
            {
                imgDado.Source = "lado1";
            }
            if (n == 2) { }
            {
                imgDado.Source = "lado2";
            }
            if(n == 3) {

                imgDado.Source = "lado3";
            }
            if(n == 4) {

                imgDado.Source = "lado4";
            }
            if(n == 5)
            {
                imgDado.Source = "lado5";
               
            }
            if(n == 6)
            {
                imgDado.Source = "lado6";
            }
        }

        private async void btVoltar_Clicked(object sender, EventArgs e)
        {
            await Navigation.PopAsync();
        }
    }
}