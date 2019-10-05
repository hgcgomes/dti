using dti.domain.core.Validacoes;
using System;
using System.Collections.Generic;
using System.Linq;

namespace dti.domain.core.Entidades
{
  public abstract class Entidade
  {
    public Guid Id { get; set; }
    public IList<string> Erros { get; private set; }

    protected Entidade()
    {
      Id = Guid.NewGuid();
      Erros = new List<string>();
    }

    protected virtual void Validar()
    {
      Erros.Clear();
    }

    public bool EhValido()
    {
      Validar();
      return !Erros.Any();
    }
  }
}
