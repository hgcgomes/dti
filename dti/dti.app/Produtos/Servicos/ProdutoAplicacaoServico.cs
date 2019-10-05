using dti.app.Produtos.Adapters;
using dti.app.Produtos.ViewModels;
using dti.domain.Produtos.Servicos;
using System;
using System.Collections.Generic;

namespace dti.app.Produtos.AplicacaoServicos
{
  public class ProdutoAplicacaoServico : IProdutoAplicacaoServico
  {
    private readonly IProdutoDominioServico _produtoDominioServico;

    public ProdutoAplicacaoServico(IProdutoDominioServico produtoDominioServico) 
    {
      _produtoDominioServico = produtoDominioServico;
    }

    public IEnumerable<ProdutoViewModel> Obter()
    {
      return ProdutoAdapter.Adapter(_produtoDominioServico.Obter());
    }
    public ProdutoViewModel Obter(Guid id)
    {
      return ProdutoAdapter.Adapter(_produtoDominioServico.Obter(id));
    }

    public void Atualizar(ProdutoViewModel produtoViewModel)
    {
      var produto = ProdutoAdapter.Adapter(produtoViewModel);
      _produtoDominioServico.Atualizar(produto);
    }

    public void Excluir(Guid id)
    {
      _produtoDominioServico.Excluir(id);
    }

    public void Dispose()
    {
      GC.SuppressFinalize(this);
    }
  }
}
