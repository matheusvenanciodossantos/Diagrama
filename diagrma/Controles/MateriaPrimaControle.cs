
using Modelos;
namespace Controles;

public class MateriaPrimaControle : BaseControle
{
  //----------------------------------------------------------------------------

  public MateriaPrimaControle() : base()
  {
    NomeDaTabela = "Materia Prima";
  }

  //----------------------------------------------------------------------------

  public virtual Registro? Ler(int idMateriaPrima)
  {
    var collection = liteDB.GetCollection<MateriaPrima>(NomeDaTabela);
    return collection.FindOne(d => d.Id == idMateriaPrima);
  }

  //----------------------------------------------------------------------------

  public virtual List<MateriaPrima>? LerTodos()
  {
    var tabela = liteDB.GetCollection<MateriaPrima>(NomeDaTabela);
    return new List<MateriaPrima>(tabela.FindAll().OrderBy(d => d.name
    
    
    
    
    ));
  }

  //----------------------------------------------------------------------------

  public virtual void Apagar(int idMateriaPrima)
  {
    var collection = liteDB.GetCollection<MateriaPrima>(NomeDaTabela);
    collection.Delete(idMateriaPrima);
  }

  //----------------------------------------------------------------------------

  public virtual void CriarOuAtualizar(MateriaPrima MateriaPrima)
  {
    var collection = liteDB.GetCollection<MateriaPrima>(NomeDaTabela);
    collection.Upsert(MateriaPrima);
  }

  //----------------------------------------------------------------------------
}