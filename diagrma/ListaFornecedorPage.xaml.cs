using Controles;
using Microsoft.Maui.Controls;

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
            ListViewFornecedor.ItemsSource =FornecedorControle.LerTodos();
        }
        void QuandoSelecionarUmItemNaListaFornecedor(object sender, SelectedItemChangedEventArgs e)
        {
            var page = new CadastroFornecedorPage();
            page.fornecedor = e.SelectedItem as Fornecedor;
            Application.Current.MainPage = page;

        }

        
    }
}
