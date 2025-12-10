using HumanoDex3TI.Model;

namespace HumanoDex3TI.View;

public partial class NovoHumano : ContentPage
{
	Humano humano = new Humano();
    public NovoHumano()
	{
		InitializeComponent();
	}

    private void SalvaClicked(object sender, EventArgs e)
    {
        if (String.IsNullOrEmpty(nomeEntry.Text) || String.IsNullOrEmpty(generoEntry.Text))
        {
            DisplayAlertAsync("Erro", "Existe campos em branco", "OK");
        }
        else{
            humano.Nome = nomeEntry.Text;
            humano.Peso = Convert.ToDecimal(pesoEntry.Text);
            humano.Altura = Convert.ToDecimal(alturaEntry.Text);
            humano.Genero = generoEntry.Text;
            var resposta = humano.insertMongo(humano);
            DisplayAlertAsync("Resultado", resposta, "OK"); 
        }

    }
}