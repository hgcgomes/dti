using dti.data.Contextos;
using dti.domain.Produtos.Entidades;
using dti.domain.Produtos.Repositorios;

namespace dti.data.Repositorios
{
  public class ProdutoRepositorio : Repositorio<Produto>, IProdutoRepositorio
  {
    public ProdutoRepositorio(DtiContexto contexto) : base(contexto)
    {
    }
  }
}
