namespace dti.data.SQLs
{
  public class ProdutoSql
  {
    public static readonly string Excluir = 
      "DELETE FROM DTI_PRODUTOS WHERE ID = @ID";

    public static readonly string Inserir = @"
      INSERT INTO DTI_PRODUTOS (ID, NOME, QUANTIDADE, VALORUNITARIO)
      VALUES (@ID, @NOME, @QUANTIDADE, @VALORUNITARIO)";

    public static readonly string Atualizar = @"
      UPDATE DTI_PRODUTOS 
      SET ID = @ID, NOME = @NOME, QUANTIDADE = @QUANTIDADE, VALORUNITARIO = @VALORUNITARIO
      WHERE ID = @ID";

    public static readonly string ObterUm = 
      "SELECT ID, NOME, QUANTIDADE, VALORUNITARIO FROM DTI_PRODUTOS WHERE ID = @ID";

    public static readonly string ObterTodos = 
      "SELECT ID, NOME, QUANTIDADE, VALORUNITARIO FROM DTI_PRODUTOS";
  }
}
