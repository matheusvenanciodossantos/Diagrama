using Controles;
using Microsoft.Maui.Controls;
using System;
using System.Threading.Tasks;

namespace diagrma
{
    public partial class CadastroMateriaPrimaPage : ContentPage
    {
        MateriaPrimaControle materiaPrimaControle= new MateriaPrimaControle();
        public CadastroMateriaPrimaPage()
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
            bool isValid = await ValidateInputs(); // Chame o método assíncrono com await

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
            if (string.IsNullOrEmpty(NomeMateriaPrimaEntry.Text))
            {
                await DisplayAlert("Erro", "O campo Nome é obrigatório.", "OK");
                return false;
            }
            if (string.IsNullOrEmpty(UnidadeMedidaEntry.Text))
            {
                await DisplayAlert("Erro", "O campo Unidade de Medida é obrigatório.", "OK");
                return false;
            }
            if (string.IsNullOrEmpty(QuantidadeEntry.Text) || !int.TryParse(QuantidadeEntry.Text, out _))
            {
                await DisplayAlert("Erro", "O campo Quantidade deve ser um número válido.", "OK");
                return false;
            }
            return true;
        }

        private async void ButtonSaveClick(object sender, EventArgs e)
        {
            var materiaPrima = new Modelos.MateriaPrima
            {
                Id = !string.IsNullOrEmpty(IdLabel.Text) ? int.Parse(IdLabel.Text) : 0,
                name = NomeMateriaPrimaEntry.Text,
                un_medida = UnidadeMedidaEntry.Text,
                qnt = QuantidadeEntry.Text.ToString(),
            };

            // Assumindo que MateriaPrimaControle é um membro da classe
            materiaPrimaControle.CriarOuAtualizar(materiaPrima);

            // Adicione uma mensagem de sucesso ou outra ação conforme necessário.
        }

        private async Task ShowFrameWithFadeIn(Frame frame)
        {
            frame.Opacity = 1;
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
