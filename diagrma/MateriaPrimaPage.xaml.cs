using Microsoft.Maui.Controls;


namespace diagrma
{
    public partial class MateriaPrimaPage : ContentPage
    {
        public MateriaPrimaPage()
        {
            InitializeComponent();
        }

        private void CancelClick(object sender, EventArgs e)
        {
            if (Application.Current != null)
                Application.Current.MainPage = new MainPage();
        }

        private async void SaveClick(object sender, EventArgs e)
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
            if (string.IsNullOrWhiteSpace(NomeMateriaPrimaEntry.Text) ||
                //string.IsNullOrWhiteSpace(TelefoneMateriaPrimaEntry.Text) ||
                //string.IsNullOrWhiteSpace(TelefoneMateriaPrima2Entry.Text) ||
                string.IsNullOrWhiteSpace(UnidadeMedidaEntry.Text) ||
                string.IsNullOrWhiteSpace(QuantidadeEntry.Text))
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