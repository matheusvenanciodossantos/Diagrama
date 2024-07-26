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
            if (Application.Current != null)
            Application.Current.MainPage = new MainPage();
        }

        private void OnSaveClicked(object sender, EventArgs e)
        {
        
        }
    }
}
