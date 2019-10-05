using dti.data.Mapeamentos;
using dti.data.Resources;
using dti.domain.Produtos.Entidades;
using System.Data.Entity;

namespace dti.data.Contextos
{
  public class DtiContexto : DbContext
  {
    public DbSet<Produto> Produtos { get; set; }
    public DtiContexto() : base(ConnectionStringsResource.DtiConnectionStrings)
    {
     
    }

    protected override void OnModelCreating(DbModelBuilder modelBuilder)
    {
      modelBuilder.Configurations.Add(new ProdutoMap());

      base.OnModelCreating(modelBuilder);
    }
  }
}
