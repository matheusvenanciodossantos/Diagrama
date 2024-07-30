using Microsoft.Maui.Controls;


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
            // Lidar com o clique do botão cancelar
        }

        private async void OnSaveClicked(object sender, EventArgs e)
        {
            // Validação dos dados de entrada
            bool isValid = ValidateInputs();

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

        private bool ValidateInputs()
        {
            // Verificar se todos os campos estão preenchidos
            if (string.IsNullOrWhiteSpace(NomeFornecedorEntry.Text) ||
                string.IsNullOrWhiteSpace(TelefoneParte1Entry.Text) ||
                string.IsNullOrWhiteSpace(TelefoneParte2Entry.Text) ||
                string.IsNullOrWhiteSpace(CnpjEntry.Text) ||
                string.IsNullOrWhiteSpace(EnderecoEntry.Text))
            {
                return false;
            }

            // Adicione validações adicionais conforme necessário (por exemplo, formato de telefone, CNPJ, etc.)

            return true;
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