using dti.app.Produtos.AplicacaoServicos;
using dti.app.Produtos.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;

namespace dti.web.api.Controllers
{
  public class ProdutoController : ApiController
  {
    private readonly IProdutoAplicacaoServico _produtoAplicacaoServico;
    public ProdutoController(IProdutoAplicacaoServico produtoAplicacaoServico)
    {
      _produtoAplicacaoServico = produtoAplicacaoServico;
    }
    // GET api/values
    public IEnumerable<ProdutoViewModel> Get()
    {
      return _produtoAplicacaoServico.Obter();
    }

    // GET api/values/5
    public ProdutoViewModel Get(Guid id)
    {

      return _produtoAplicacaoServico.Obter(id);
    }

    // POST api/values
    public void Post([FromBody]ProdutoViewModel produto)
    {
      _produtoAplicacaoServico.Atualizar(produto);
    }

    // PUT api/values/5
    public void Put([FromBody]ProdutoViewModel produto)
    {
      _produtoAplicacaoServico.Atualizar(produto);
    }

    // DELETE api/values/5
    public void Delete(Guid id)
    {
      _produtoAplicacaoServico.Excluir(id);
    }
  }
}