using Controles;
using Microsoft.Maui.Controls;
using Modelos;
using System.Threading.Tasks;

namespace diagrma
{
    public partial class CadastroClientePage : ContentPage
    {
        ClienteControle clienteControle= new ClienteControle();
        public Cliente cliente;
        public CadastroClientePage()
        {
            InitializeComponent();
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();

            if (cliente != null)
            {
                IdLabel.Text = cliente.Id.ToString();
                NomeClienteEntry.Text = cliente.name;
                TelefoneClienteEntry.Text = cliente.telephone;
                TelefoneCliente2Entry.Text = cliente.telephone;
                CPFEntry.Text            = cliente.cnpj_cpf;
                EnderecoClienteEntry.Text = cliente.address;
            }
        }

        void BotaoVoltar(object sender, EventArgs e)
        {
            if (Application.Current != null)
                Application.Current.MainPage = new MainPage();
        }   
        
        private async void OnSalvarDadosClicked(object sender, EventArgs e)
        {
            var cliente = new Modelos.Cliente();
            if (!string.IsNullOrEmpty(IdLabel.Text))
                cliente.Id = int.Parse(IdLabel.Text);
            else
                cliente.Id = 0;
            cliente.name = NomeClienteEntry.Text;
            cliente.telephone = TelefoneClienteEntry.Text;
            cliente.telephone = TelefoneCliente2Entry.Text;
            cliente.cnpj_cpf = CPFEntry.Text;
            cliente.address = EnderecoClienteEntry.Text;

            // Assumindo que clienteControle é um membro da classe
            clienteControle.CriarOuAtualizar(cliente);

            await DisplayAlert("Salvar", "Dados salvos com sucesso!", "OK");
            
            if (Application.Current != null)
                Application.Current.MainPage = new ListaClientePage();
        }

    private async Task<bool> ValidateInputs()
        {
            // Verifica se a Entry do Nome está vazia
            if (string.IsNullOrEmpty(NomeClienteEntry.Text))
            {
                await DisplayAlert("Cadastrar", "O campo Nome é obrigatório", "OK");
                return false;
            }
            // Verifica se a Entry do Telefone está vazia
            else if (string.IsNullOrEmpty(TelefoneClienteEntry.Text))
            {
                await DisplayAlert("Cadastrar", "O campo Telefone é obrigatório", "OK");
                return false;
            }
            // Verifica se a Entry do Telefone 2 está vazia
            else if (string.IsNullOrEmpty(TelefoneCliente2Entry.Text))
            {
                await DisplayAlert("Cadastrar", "O campo Telefone 2 é obrigatório", "OK");
                return false;
            }
            // Verifica se a Entry do CPF está vazia
            else if (string.IsNullOrEmpty(CPFEntry.Text))
            {
                await DisplayAlert("Cadastrar", "O campo CPF é obrigatório", "OK");
                return false;
            }
            // Verifica se a Entry do Endereço está vazia
            else if (string.IsNullOrEmpty(EnderecoClienteEntry.Text))
            {
                await DisplayAlert("Cadastrar", "O campo Endereço é obrigatório", "OK");
                return false;
            }
            else
                return true;
        
        }


        private async void CancelClicked(object sender, EventArgs e)
  {
    
         if (cliente == null || cliente.Id < 1)
         await DisplayAlert("Erro", "Nenhum cliente para excluir", "ok");
        else if (await DisplayAlert("Excluir","Tem certeza que deseja excluir esse cliente?","Excluir Cliente","cancelar")) // Caso o usuário tocar no Botão "Excluir Cliente"
    {
      
        clienteControle.Apagar(cliente.Id);
        Application.Current.MainPage = new ListaClientePage(); 
    }
  }    
   
    }

}


