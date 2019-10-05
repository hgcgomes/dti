using dti.domain.core.Entidades;
using System.Data.Entity.ModelConfiguration;

namespace dti.data.Mapeamentos
{
  public abstract class Map<TEntidade> : EntityTypeConfiguration<TEntidade>
    where TEntidade : Entidade
  {
    public Map(string tabela)
    {
      ToTable(tabela);
      HasKey(e => e.Id);
      Property(e => e.Id)
        .HasColumnName("ID")
        .HasColumnType("VARCHAR(50)")
        .IsRequired();
    }
  }
}
