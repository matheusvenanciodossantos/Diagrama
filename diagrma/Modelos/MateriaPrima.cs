
namespace Modelos
{
	public class MateriaPrima : Registro
		{
		public string name {get;set;}
        public string un_medida {get;set;}
        public int qnt {get;set;}
        public string cnpj_cpf {get;set;}
		public int Id { get; set; }
		public float preco {get;set;}
		}
}