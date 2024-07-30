using Microsoft.Maui.Controls;
namespace diagrma
{
    public partial class ClientePage : ContentPage
    {
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
            bool isValid = ValidateInputs();

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

        private bool ValidateInputs()
        {
            // Verificar se todos os campos estão preenchidos
            if (string.IsNullOrWhiteSpace(NomeClienteEntry.Text) ||
                string.IsNullOrWhiteSpace(TelefoneClienteEntry.Text) ||
                string.IsNullOrWhiteSpace(TelefoneCliente2Entry.Text) ||
                string.IsNullOrWhiteSpace(CPFEntry.Text) ||
                string.IsNullOrWhiteSpace(EnderecoClienteEntry.Text))
            {
                return false;
            }

            // Adicione validações adicionais conforme necessário (por exemplo, formato de telefone, CNPJ, etc.)

            return true;
        }

        private async Task HideFrameAfterDelay(Frame frame, int delay)
        {
            await Task.Delay(delay);
            frame.IsVisible = false;
        }
    }
}
