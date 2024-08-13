namespace Modelos
{
    public class Papai
    {
        public string name;
        public string telephone;
        public string address;
        public string cnpj_cpf;
        public string un_medida;
        public int qnt;
        public int id_materia_prima;
        public int id_produto;
        public int IdFornecedor;
        public float preco;
        public int id;
            public void SetName(string name)
            {
                this.name = name;
            }
            public string GetName()
            {
            return name;
            }
            public void SetIdFornecedor(int id_produto)
            {
                this.IdFornecedor = IdFornecedor;
            }
            public int GetIdFornecedor()
            {
                return IdFornecedor;
            }
            public void SetAddress(string address)
            {
                this.address = address;
            }
            public string GetAddress()
            {
                return address;
            }
            public void SetCNPJ(string cnpj_cpf)
            {
                this.cnpj_cpf = cnpj_cpf;
            }
            public string GetCNPJ()
            {
                return cnpj_cpf;
            }
            public void SetTelefone(string telephone)
            {
                this.telephone = telephone ;
            }
            public string GetTelefone( )
            {
                return telephone;
            }
                public void SetPreco(float preco)
            {
                this.preco = preco;
            }
            public float GetPreco()
            {
                return preco;
            }
    }
}