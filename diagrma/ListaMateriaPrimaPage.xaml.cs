using Microsoft.Maui.Controls;

namespace diagrma
{
    public partial class ListaMateriaPrimaPage : ContentPage
    {
        public ListaMateriaPrimaPage()
        {
            InitializeComponent();
        }

        private void ButtonBack(object sender, EventArgs e)
        {
            if (Application.Current != null)
                Application.Current.MainPage = new IdTelas();
        }
    }
}
