using dti.app.Produtos.ViewModels;
using dti.domain.Produtos.Entidades;
using FastMapper;
using System.Collections.Generic;

namespace dti.app.Produtos.Adapters
{
  public class ProdutoAdapter
  {
    public static ProdutoViewModel Adapter(Produto produto)
    {
      return TypeAdapter.Adapt<Produto, ProdutoViewModel>(produto);
    }

    public static Produto Adapter(ProdutoViewModel produto)
    {
      return TypeAdapter.Adapt<ProdutoViewModel, Produto>(produto);
    }

    public static IEnumerable<ProdutoViewModel> Adapter(IEnumerable<Produto> produtos)
    {
      return TypeAdapter.Adapt< IEnumerable<Produto>, IEnumerable<ProdutoViewModel>>(produtos);
    }

    public static IEnumerable<Produto> Adapter(IEnumerable<ProdutoViewModel> produtos)
    {
      return TypeAdapter.Adapt< IEnumerable<ProdutoViewModel>, IEnumerable<Produto>>(produtos);
    }
  }
}
