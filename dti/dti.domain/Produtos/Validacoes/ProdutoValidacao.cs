using dti.domain.core.Validacoes;
using dti.domain.Produtos.Entidades;
using dti.domain.Produtos.Especificacoes;
using dti.domain.Produtos.Resources;

namespace dti.domain.Produtos.Validacoes
{
  public class ProdutoValidacao : Validacao<Produto>
  {
    public ProdutoValidacao(Produto entidade)
    {
      var possuiNomeProdutoValido = new ProdutoDeveTerNomeValidoEspecificacao();
      var possuiQuantidadeValida = new ProdutoDeveTerQuantidadeMaiorOuIgualZeroEspecificacao();
      var possuiValorValido = new ProdutoDeveTerValorMaiorOuIgualZeroEspecificacao();

      Validar(entidade, ProdutoValidacaoResource.NomeInvalido, possuiNomeProdutoValido);
      Validar(entidade, ProdutoValidacaoResource.QuantidadeInvalida, possuiQuantidadeValida);
      Validar(entidade, ProdutoValidacaoResource.ValorUnitarioInvalido, possuiValorValido);
    }
  }
}
