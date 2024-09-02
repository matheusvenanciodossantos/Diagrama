    using Controles;
using Microsoft.Maui.Controls;
using Modelos;

namespace diagrma
{
    public partial class ListaMateriaPrimaPage : ContentPage
    {
        MateriaPrimaControle materiaprimaControle = new MateriaPrimaControle();
        public ListaMateriaPrimaPage()
        {
            InitializeComponent();
        }
        protected override void OnAppearing()
        {
            base.OnAppearing();
            ListViewMateriaPrima.ItemsSource =materiaprimaControle.LerTodos();
        }
        void QuandoSelecionarUmItemNaListaMateriaPrima(object sender, SelectedItemChangedEventArgs e)
        {
            var page = new CadastroMateriaPrimaPage();
            page.MateriaPrima = e.SelectedItem as MateriaPrima;
            Application.Current.MainPage = page;

        }

        private void BotaoVoltarIdMP(object sender, EventArgs e)
        {
         if (Application.Current != null)
                Application.Current.MainPage = new IdTelas();
        }
    }
}
