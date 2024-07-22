namespace diagrma
{
    public class Papai
    {
        string name;
        string telephone;
        string address;
        int id;
        string cnpj_cpf;
        string un_medida;
        int qnt;
        int id_materia_prima;
        int id_produto;
        int id_fornecedor;
        decimal preco;
            public void SetName(string name)
            {
                this.name =name;
            }
            public void GetName()
            {
            return name;
            }
            public void SetIdFornecedor(int id_produto)
            {
                this.IdFornecedor;
            }
            public void GetIdFornecedor(int id_produto)
            {
                return IdFornecedor;
            }
            public void SetAddress(string address)
            {
                this.Address;
            }
            public void GetAddress()
            {
                return Address;
            }
            public void SetCNPJ(string cnpj_cpf)
            {
                this.CNPJ;
            }
            public void GetCNPJ()
            {
                return CNPJ;
            }
            public void SetTelefone(string telephone)
            {
                this.telephone;
            }
            public void GetTelefone(string telephone)
            {
                return telephone;
            }
                public void SetPreco(string preco)
            {
                this.preco;
            }
            public void GetPreco(string preco)
            {
                return preco;
            }
    }
}