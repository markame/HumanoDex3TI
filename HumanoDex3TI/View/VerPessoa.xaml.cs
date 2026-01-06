using HumanoDex3TI.Model;


namespace HumanoDex3TI.View;

public partial class VerPessoa : ContentPage
{
	public VerPessoa()
	{
        InitializeComponent();
        CarregarHumanos();


    }
    private async void CarregarHumanos()
    {
        Humano h = new Humano();
        var lista = await h.GetHumanosAsync();
        humanoslist.ItemsSource = lista;
    }
}