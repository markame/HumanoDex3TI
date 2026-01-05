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
            Humano h = new Humano();
            humanoslist.ItemsSource = h.GetHumanos();
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new NovoHumano());
        }

        private async void VerPessoa_Clicked(object sender, EventArgs e)
        {
            Humano h  =  new Humano();
            CollectionView collectionView = new CollectionView();
            humanoslist.ItemsSource = h.GetHumanos();
      
        }
    }
}
