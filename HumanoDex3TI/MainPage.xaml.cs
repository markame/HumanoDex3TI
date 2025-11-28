using HumanoDex3TI.Model;
using HumanoDex3TI.Service;
using System.Threading.Tasks;
using HumanoDex3TI.View;

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
    }
}
