using dti.domain.core.Entidades;
using dti.domain.Produtos.Validacoes;

namespace dti.domain.Produtos.Entidades
{
  public class Produto : Entidade
  {
    public string Nome {get; set; }
    public int Quantidade { get; set; }
    public decimal ValorUnitario { get; set; }

    protected override void Validar()
    {
      base.Validar();
      new ProdutoValidacao(this);
    }
  }
}
