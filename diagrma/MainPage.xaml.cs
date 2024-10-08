﻿using Microsoft.Maui.Controls;
namespace diagrma
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }
        private void ClikedFornecedor(object sender, EventArgs e)
        {
            if (Application.Current != null)
                Application.Current.MainPage = new CadastroFornecedorPage();
        }
        private void ClikedCliente(object sender, EventArgs e)
        {
            if (Application.Current != null)
                Application.Current.MainPage = new CadastroClientePage();
        }
         private void ClikedMateriaPrima(object sender, EventArgs e)
        {
            if (Application.Current != null)
                Application.Current.MainPage = new CadastroMateriaPrimaPage();
        }
         private void ClikedIdTelas(object sender, EventArgs e)
        {
            if (Application.Current != null)
                Application.Current.MainPage = new IdTelas();
        }
    }
}

