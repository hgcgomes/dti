using dti.domain.core.Especificacoes;
using dti.domain.Produtos.Entidades;

namespace dti.domain.Produtos.Especificacoes
{
  public class ProdutoDeveTerNomeValidoEspecificacao : Especificacao<Produto>
  {
    public override bool EhValido(Produto entidade)
    {
      if (!base.EhValido(entidade))
        return false;

      return !string.IsNullOrEmpty(entidade.Nome);
    }
  }
}
