using Microsoft.Maui.Controls;

namespace diagrma
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }
            private void PaginaFornecedor(object sender, EventArgs e)
        {
            if (Application.Current != null)
            Application.Current.MainPage = new CadastroFornecedorPage();
        }
    
    
    }

}

