using dti.domain.core.Entidades;
using dti.domain.core.Especificacoes;

namespace dti.domain.core.Validacoes
{
  public abstract class Validacao<TEntidade>
    where TEntidade : Entidade
  {
    protected void Validar<TEspecificacao>(TEntidade entidade, string erro, TEspecificacao especificao)
      where TEspecificacao : Especificacao<TEntidade>
    {
      if (especificao.EhValido(entidade)) return;

      entidade.Erros.Add(erro);
    }
  }
}
