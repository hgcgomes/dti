using dti.domain.core.Servicos;
using dti.domain.Produtos.Entidades;
using dti.domain.Produtos.Repositorios;

namespace dti.domain.Produtos.Servicos
{
  public class ProdutoDominioServico : DominioServico<Produto>, IProdutoDominioServico
  {
    public ProdutoDominioServico(IProdutoRepositorio repositorio) : base(repositorio)
    {
    }
  }
}
