using dti.domain.core.Entidades;
using dti.domain.core.Repositorios;
using System;
using System.Collections.Generic;

namespace dti.domain.core.Servicos
{
  public class DominioServico<TEntidade> : IDominioServico<TEntidade>
    where TEntidade : Entidade
  {
    protected IRepositorio<TEntidade> _repositorio;

    public DominioServico(IRepositorio<TEntidade> repositorio)
    {
      _repositorio = repositorio;
    }
    public void Atualizar(TEntidade entidade)
    {
      _repositorio.Atualizar(entidade);
    }

    public void Dispose()
    {
      GC.SuppressFinalize(this);
    }

    public void Excluir(Guid id)
    {
      _repositorio.Excluir(id);
    }

    public TEntidade Obter(Guid id)
    {
      return _repositorio.Obter(id);
    }

    public IEnumerable<TEntidade> Obter()
    {
      return _repositorio.Obter();
    }
  }
}
