using HumanoDex3TI.Model;
using HumanoDex3TI.Service;
using System.Threading.Tasks;
using HumanoDex3TI.View;
using MongoDB.Bson;

namespace HumanoDex3TI
{
    public partial class MainPage : ContentPage
    {
       

        public MainPage()
        {
            InitializeComponent();
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new NovoHumano());
        }

        private async void VerPessoa_Clicked(object sender, EventArgs e)
        {
            Humano humano = new Humano();
            var resultado = await humano.selectMongo("Augustinho");
            foreach (var docs in resultado)
            {
                DisplayAlertAsync("Resultado", docs.ToBsonDocument().ToString(), "OK");
            }
        }
    }
}
