
namespace Modelos
{
	public class Cliente : Registro
		{
	    public string name {get;set;}
        public string telephone {get;set;}
        public string address {get;set;}
        public string cnpj_cpf {get;set;}
        public int Id { get; set; }
        public object Sobrenome { get; set; }
    }
}