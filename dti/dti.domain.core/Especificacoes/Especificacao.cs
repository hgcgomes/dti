using dti.domain.core.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dti.domain.core.Especificacoes
{
  public abstract class Especificacao<TEntidade>
    where TEntidade : Entidade
  {
    public virtual bool EhValido(TEntidade entidade)
    {
      return entidade != null;
    }
  }
}
