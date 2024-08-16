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
            if (Application.Current != null)
                Application.Current.MainPage = new IdFornecedorPage();
        }

        private async void OnMateriaPrimaClicked(object sender, EventArgs e)
        {
            if (Application.Current != null)
                Application.Current.MainPage = new IdMateriaPrimaPage();
        }
        private void BackButton(object sender, EventArgs e)
        {
            if (Application.Current != null)
                Application.Current.MainPage = new MainPage();
        }
    }
}
