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
            // Navegar para a página de Clientes
            await DisplayAlert("Clientes", "Navegar para a página de Clientes", "OK");
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
    }
}
