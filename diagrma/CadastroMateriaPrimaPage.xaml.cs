using Controles;
using Microsoft.Maui.Controls;
using Modelos;
using System;
using System.Threading.Tasks;

namespace diagrma
{
    public partial class CadastroMateriaPrimaPage : ContentPage
    {
        MateriaPrimaControle materiaPrimaControle= new MateriaPrimaControle();
        public MateriaPrima materiaprima;
        internal MateriaPrima MateriaPrima;

        public MateriaPrima Materiaprima { get; internal set; }

        public CadastroMateriaPrimaPage()
        {
            InitializeComponent();
        }

        private void CancelClick(object sender, EventArgs e)
        {
            if (Application.Current != null)
                Application.Current.MainPage = new MainPage();
        }

        private void BotaoVoltarMateriaPrima(object sender, EventArgs e)
        {
            if (Application.Current != null)
                Application.Current.MainPage = new MainPage();
        }

        private async Task<bool> ValidateInputs()
        {
            // Exemplo de validação. Adapte conforme necessário.
            if (string.IsNullOrEmpty(NomeMateriaPrimaEntry.Text))
            {
                await DisplayAlert("Erro", "O campo Nome é obrigatório.", "OK");
                return false;
            }
            if (string.IsNullOrEmpty(UnidadeMedidaEntry.Text))
            {
                await DisplayAlert("Erro", "O campo Unidade de Medida é obrigatório.", "OK");
                return false;
            }
            if (string.IsNullOrEmpty(QuantidadeEntry.Text) || !int.TryParse(QuantidadeEntry.Text, out _))
            {
                await DisplayAlert("Erro", "O campo Quantidade deve ser um número válido.", "OK");
                return false;
            }
            return true;
        }

        private async void ButtonSaveClick(object sender, EventArgs e)
        {
            var materiaPrima = new Modelos.MateriaPrima
            {
                Id = !string.IsNullOrEmpty(IdLabel.Text) ? int.Parse(IdLabel.Text) : 0,
                name = NomeMateriaPrimaEntry.Text,
                un_medida = UnidadeMedidaEntry.Text,
                qnt = QuantidadeEntry.Text.ToString(),
            };

            // Assumindo que MateriaPrimaControle é um membro da classe
            materiaPrimaControle.CriarOuAtualizar(materiaPrima);

            await DisplayAlert("Salvar"," Dados salvos com sucesso!", "OK");

            if (Application.Current != null)
                Application.Current.MainPage = new ListaMateriaPrimaPage();
                           
        }

      private async void CancelClicked(object sender, EventArgs e)
  {
    
         if (materiaprima == null || materiaprima.Id < 1)
         await DisplayAlert("Erro", "Nenhum cliente para excluir", "ok");
        else if (await DisplayAlert("Excluir","Tem certeza que deseja excluir esse cliente?","Excluir Cliente","cancelar")) 
      
        materiaPrimaControle.Apagar(materiaprima.Id);
        Application.Current.MainPage = new ListaClientePage(); 
    }
  }    
    }

