using System;
using System.Collections.Generic;
using System.Linq;

namespace dti.app.ViewModels
{
  public class ViewModel
  {
    public Guid Id { get; set; }
    public IList<string> Erros { get; private set; }

    protected ViewModel()
    {
      Id = Guid.NewGuid();
      Erros = new List<string>();
    }

    public bool EhValido()
    {
      return !Erros.Any();
    }
  }
}
