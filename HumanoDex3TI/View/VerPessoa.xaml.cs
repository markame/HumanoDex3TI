using HumanoDex3TI.Model;


namespace HumanoDex3TI.View;

public partial class VerPessoa : ContentPage
{
	public VerPessoa()
	{
        Humano h = new Humano();
        InitializeComponent();
        humanoslist.ItemsSource = h.GetHumanos();
       
    }
}