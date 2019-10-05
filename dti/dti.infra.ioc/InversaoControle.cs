using dti.app.Produtos.AplicacaoServicos;
using dti.data.Contextos;
using dti.data.Repositorios;
using dti.domain.core.Repositorios;
using dti.domain.core.Servicos;
using dti.domain.Produtos.Repositorios;
using dti.domain.Produtos.Servicos;
using SimpleInjector;
using SimpleInjector.Lifestyles;

namespace dti.infra.ioc
{
  public class InversaoControle
  {
    public static void CriarInstancia(out Container dependencias)
    {
      dependencias = new Container();
      dependencias.Options.DefaultScopedLifestyle = 
        new ThreadScopedLifestyle();

    }
    public static void Resolver(Container dependencias)
    {
      var lifeStyle = Lifestyle.Singleton;

      dependencias.Register<DtiContexto>(lifeStyle);

      dependencias.Register(typeof(IRepositorio<>), typeof(Repositorio<>), lifeStyle);
      dependencias.Register<IProdutoRepositorio, ProdutoRepositorio>(lifeStyle);

      dependencias.Register(typeof(IDominioServico<>), typeof(DominioServico<>), lifeStyle);
      dependencias.Register<IProdutoDominioServico, ProdutoDominioServico>(lifeStyle);

      dependencias.Register<IProdutoAplicacaoServico, ProdutoAplicacaoServico>(lifeStyle);

    }
  }
}
