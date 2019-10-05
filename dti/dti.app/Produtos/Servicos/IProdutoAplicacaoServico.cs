using dti.app.Produtos.ViewModels;
using System;
using System.Collections.Generic;

namespace dti.app.Produtos.AplicacaoServicos
{
  public interface IProdutoAplicacaoServico : IDisposable
  {
    IEnumerable<ProdutoViewModel> Obter();

    ProdutoViewModel Obter(Guid id);

    void Atualizar(ProdutoViewModel produtoViewModel);

    void Excluir(Guid id);
  }
}
