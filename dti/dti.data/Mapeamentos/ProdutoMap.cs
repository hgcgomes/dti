using dti.domain.Produtos.Entidades;

namespace dti.data.Mapeamentos
{
  public sealed class ProdutoMap : Map<Produto>
  {
    public ProdutoMap() : base("DTI_PRODUTOS")
    {
      Property(p => p.Nome)
       .HasColumnName("NOME")
       .HasColumnType("VARCHAR(50)")
       .IsRequired();

      Property(p => p.Quantidade)
       .HasColumnName("QUANTIDADE")
       .HasColumnType("INT")
       .IsRequired();

      Property(p => p.ValorUnitario)
       .HasColumnName("VALORUNITARIO")
       .HasColumnType("DECIMAL")
       .IsRequired();
    }
  }
}
