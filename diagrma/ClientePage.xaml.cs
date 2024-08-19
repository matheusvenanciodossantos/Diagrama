using Controles;
using Microsoft.Maui.Controls;
using System.Threading.Tasks;

namespace diagrma
{
    public partial class ClientePage : ContentPage
    {
        ClienteControle clienteControle= new ClienteControle();
        public ClientePage()
        {
            InitializeComponent();
        }

        private void CancelClicked(object sender, EventArgs e)
        {
            if (Application.Current != null)
                Application.Current.MainPage = new MainPage();
        }

        private async void SaveClicked(object sender, EventArgs e)
        {
            // Validação dos dados de entrada
            bool isValid = await ValidateInputs();

            if (isValid)
            {
                // Exibir mensagem de sucesso
                SucessoFrame.IsVisible = true;
                ErroFrame.IsVisible = false;

                // Ocultar mensagem de sucesso após 3 segundos
                await HideFrameAfterDelay(SucessoFrame, 3000);
            }
            else
            {
                // Exibir mensagem de erro
                SucessoFrame.IsVisible = false;
                ErroFrame.IsVisible = true;

                // Ocultar mensagem de erro após 3 segundos
                await HideFrameAfterDelay(ErroFrame, 3000);
            }
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
        }

        private async Task HideFrameAfterDelay(Frame frame, int delay)
        {
            await Task.Delay(delay);
            frame.IsVisible = false;
        }
    }
}


