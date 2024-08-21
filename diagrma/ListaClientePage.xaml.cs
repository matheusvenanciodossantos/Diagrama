using Controles;
using Microsoft.Maui.Controls;
using System.Collections.ObjectModel;
using System.Linq;
using Modelos;

namespace diagrma
{
    public partial class ListaClientePage : ContentPage
    {
        ClienteControle clienteControle = new ClienteControle();
        public ListaClientePage()
        {
            InitializeComponent();
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            ListViewClientes.ItemsSource = clienteControle.LerTodos();
        }

        void QuandoSelecionarUmItemNaLista(object sender, SelectedItemChangedEventArgs e)
        {
            var page = new CadastroClientePage();
            page.cliente = e.SelectedItem as Cliente;
            Application.Current.MainPage = page;
        }
        
    
    }

}
