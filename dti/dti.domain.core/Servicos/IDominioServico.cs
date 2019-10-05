using dti.domain.core.Entidades;
using System;
using System.Collections.Generic;

namespace dti.domain.core.Servicos
{
  public interface IDominioServico<TEntidade> : IDisposable
    where TEntidade : Entidade
  {
    IEnumerable<TEntidade> Obter();
    TEntidade Obter(Guid id);
    void Atualizar(TEntidade entidade);
    void Excluir(Guid id);
  }
}
