using Microsoft.Maui.Controls;
using System;
using System.Threading.Tasks;

namespace diagrma
{
    public partial class CadastroFornecedorPage : ContentPage
    {
        public CadastroFornecedorPage()
        {
            InitializeComponent();
        }

        private void OnCancelClicked(object sender, EventArgs e)
        {
            if (Application.Current != null)
                Application.Current.MainPage = new MainPage();
        }

        private async void OnSaveClicked(object sender, EventArgs e)
        {
            // Validação dos dados de entrada
            bool isValid = await ValidateInputs(); // Use await para chamar métodos assíncronos

            if (isValid)
            {
                // Exibir mensagem de sucesso com animação de fade-in
                await ShowFrameWithFadeIn(SucessoFrame);

                // Ocultar mensagem de sucesso após 3 segundos com animação de fade-out
                await HideFrameWithFadeOut(SucessoFrame, 3000);
            }
            else
            {
                // Exibir mensagem de erro com animação de fade-in
                await ShowFrameWithFadeIn(ErroFrame);

                // Ocultar mensagem de erro após 3 segundos com animação de fade-out
                await HideFrameWithFadeOut(ErroFrame, 3000);
            }
        }

        private async Task<bool> ValidateInputs()
        {
            // Exemplo de validação. Adapte conforme necessário.
            if (string.IsNullOrEmpty(NomeFornecedorEntry.Text))
            {
                await DisplayAlert("Erro", "O nome do fornecedor é obrigatório.", "OK");
                return false;
            }
            // Adicione mais validações conforme necessário.
            return true;
        }

        private async void OnSalvarFornecedor(object sender, EventArgs e)
        {
            var fornecedor = new Modelos.Fornecedor
            {
                Id = !string.IsNullOrEmpty(IdLabel.Text) ? int.Parse(IdLabel.Text) : 0,
                name = NomeFornecedorEntry.Text,
                telephone = $"{TelefoneParte1Entry.Text}, {TelefoneParte2Entry.Text}", // Supondo que você deseja juntar os dois números de telefone
                cnpj_cpf = CnpjEntry.Text,
                address = EnderecoEntry.Text
            };

            // Assumindo que FornecedorControle é um membro da classe
            FornecedorControle.CriarOuAtualizar(fornecedor);

            // Adicione uma mensagem de sucesso ou outra ação conforme necessário.
        }

        private async Task ShowFrameWithFadeIn(Frame frame)
        {
            frame.Opacity = 0;
            frame.IsVisible = true;
            await frame.FadeTo(1, 500); // 500ms de animação para fade-in
        }

        private async Task HideFrameWithFadeOut(Frame frame, int delay)
        {
            await Task.Delay(delay);
            await frame.FadeTo(0, 500); // 500ms de animação para fade-out
            frame.IsVisible = false;
        }
    }
}
