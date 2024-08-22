using System;
using Controles;
using Microsoft.Maui.Controls;
using Modelos;
namespace diagrma
{
    public partial class CadastroFornecedorPage : ContentPage
    {
        FornecedorControle fornecedorControle= new FornecedorControle();
        public Fornecedor fornecedor;
        public CadastroFornecedorPage()
        {
            InitializeComponent();
        }

        private void OnCancelClicked(object sender, EventArgs e)
        {
         
        }

        

        

        private async void OnSalvarFornecedor(object sender, EventArgs e)
        {
            var fornecedor = new Modelos.Fornecedor();
            if (!string.IsNullOrEmpty(IdLabel.text))
            fornecedor.Id = int.Parse(IdLabel.text);
            else 
            fornecedor.Id = 0;
            fornecedor.name = NomeFornecedorEntry.Text;
            fornecedor.telephone = TelefoneFornecedorEntry;
            fornecedor.telephone = TelefoneFornecedor2Entry;
            fornecedor.cnpj_cpf = CNPJEntry;
            fornecedor.address = EnderecoFornecedorEntry;

            fornecedorControle.CriarOuAtualizar(fornecedor);
            
            await DisplayAlert("Salvar, Dados salvos com sucesso!", "OK");
            if (Application.Current != null)
                Application.Current.MainPage = new IdTelas();
                           
        }
        private async Task<bool> ValidateInputs()
        {
            // Exemplo de validação. Adapte conforme necessário.
            if (string.IsNullOrEmpty(NomeFornecedorEntry.Text))
            {
                await DisplayAlert("Erro", "O nome do fornecedor é obrigatório.", "OK");
                return false;
            }
            // Adicione mais validações conforme necessário.
            return true;
        }
        private void BotaoVoltarFornecedor(object sender, EventArgs e)
        {
            if (Application.Current != null)
                Application.Current.MainPage = new MainPage();
        }   
    
    }
}
