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

        private void BotaoVoltarFornecedor(object sender, EventArgs e)
        {
         if (Application.Current != null)
                Application.Current.MainPage = new MainPage();
        }

        

        

        private async void OnSalvarFornecedor(object sender, EventArgs e)
        {
            var fornecedor = new Modelos.Fornecedor();
            if (!string.IsNullOrEmpty(IdLabel.Text))
            fornecedor.Id = int.Parse(IdLabel.Text);
            else 
            fornecedor.Id = 0;
            fornecedor.name = NomeFornecedorEntry.Text;
            fornecedor.telephone = TelefoneFornecedorEntry.Text;
            fornecedor.telephone = TelefoneFornecedor2Entry.Text;
            fornecedor.cnpj_cpf = CNPJEntry.Text;
            fornecedor.address = EnderecoFornecedorEntry.Text;

            fornecedorControle.CriarOuAtualizar(fornecedor);
            
            await DisplayAlert("Salvar"," Dados salvos com sucesso!", "OK");

            if (Application.Current != null)
                Application.Current.MainPage = new ListaFornecedorPage();
                           
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
    
    private async void CancelClicked(object sender, EventArgs e)
  {
    
         if (fornecedor == null || fornecedor.Id < 1)
         await DisplayAlert("Erro", "Nenhum cliente para excluir", "ok");
        else if (await DisplayAlert("Excluir","Tem certeza que deseja excluir esse cliente?","Excluir Cliente","cancelar")) // Caso o usuário tocar no Botão "Excluir Cliente"
    {
      
        fornecedorControle.Apagar(fornecedor.Id);
        Application.Current.MainPage = new ListaClientePage(); 
    }
  }    

    }
}
