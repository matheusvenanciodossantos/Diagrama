using Microsoft.Maui.Controls;

namespace diagrma
{
    public partial class IdTelas : ContentPage
    {
        public IdTelas()
        {
            InitializeComponent();
        }

        private async void OnClientesClicked(object sender, EventArgs e)
        {
            if (Application.Current != null)
                Application.Current.MainPage = new IdClientesPage();
        }

        private async void OnFornecedorClicked(object sender, EventArgs e)
        {
            // Navegar para a página de Fornecedor
            await DisplayAlert("Fornecedor", "Navegar para a página de Fornecedor", "OK");
        }

        private async void OnMateriaPrimaClicked(object sender, EventArgs e)
        {
            // Navegar para a página de Matéria-Prima
            await DisplayAlert("Matéria-Prima", "Navegar para a página de Matéria-Prima", "OK");
        }
        private void BackButton(object sender, EventArgs e)
        {
            if (Application.Current != null)
                Application.Current.MainPage = new MainPage();
        }
    }
}
