using dti.infra.ioc;
using SimpleInjector;
using SimpleInjector.Integration.WebApi;
using System.Web.Http;

namespace dti.web.api.App_Start
{
  public class SimpleInejectorConfig
  {
    public static void Resolver()
    {
      InversaoControle.CriarInstancia(out Container dependencias);
      InversaoControle.Resolver(dependencias);
      var globalConfiguration = GlobalConfiguration.Configuration;

      dependencias.RegisterWebApiControllers(globalConfiguration);

      dependencias.Verify();

      globalConfiguration.DependencyResolver = new SimpleInjectorWebApiDependencyResolver(dependencias);
    }
  }
}