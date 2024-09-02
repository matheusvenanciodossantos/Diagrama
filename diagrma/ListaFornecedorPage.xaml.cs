using Controles;
using Microsoft.Maui.Controls;
using Modelos;

namespace diagrma
{
    public partial class ListaFornecedorPage : ContentPage
    {
        FornecedorControle fornecedorControle = new FornecedorControle();
        public ListaFornecedorPage()
        {
            InitializeComponent();
        }
        protected override void OnAppearing()
        {
            base.OnAppearing();
            ListViewFornecedor.ItemsSource =fornecedorControle.LerTodos();
        }
        void QuandoSelecionarUmItemNaListaFornecedor(object sender, SelectedItemChangedEventArgs e)
        {
            var page = new CadastroFornecedorPage();
            page.fornecedor = e.SelectedItem as Fornecedor;
            Application.Current.MainPage = page;

        }

        private void BotaoVoltarId(object sender, EventArgs e)
        {
         if (Application.Current != null)
                Application.Current.MainPage = new IdTelas();
        }
    }
}
