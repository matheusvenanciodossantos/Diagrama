namespace diagrma;

public class Cliente : Papai
{
	public void SetName(string name)
	{
		this.name =name;
	}
    public void GetName()
    {
     return name;
    }
	public void SetIdFornecedor(int id)
	{
		this.IdFornecedor;
	}
	public void GetIdFornecedor(int id)
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
}