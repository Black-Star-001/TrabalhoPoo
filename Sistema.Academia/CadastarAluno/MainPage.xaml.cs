namespace CadastarAluno;

public partial class MainPage : ContentPage
{
	int count = 0;

	public MainPage()
	{
		InitializeComponent();
	}
    private void OnSalvarClicked(object sender, EventArgs e){
		Sistema.Academia.Modelos.Aluno aluno = new();

		  aluno.Nome = NomeEnrty.Text;
		  aluno.Cpf = CpfEnrty.Text;
		  aluno.Idade = IdadeEnrty.Text;
		  aluno.Sexo = SexoEnrty.Text;
		  aluno.Nascimento = NascimentoEnrty.Text; 

			ResultadoLabel.Text = aluno.ToString(); 
    }
}

