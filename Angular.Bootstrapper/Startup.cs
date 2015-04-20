using System.Linq;
using System.Management.Instrumentation;
using System.Net.Http.Formatting;
using System.Web.Http;

using Microsoft.Owin;
using Microsoft.Practices.Unity;
using Microsoft.Practices.Unity.WebApi;
using Newtonsoft.Json.Serialization;
using Owin;

[assembly: OwinStartup(typeof(Angular.Bootstrapper.Startup))]
namespace Angular.Bootstrapper
{
    public class Startup
    {

        public void Configuration(IAppBuilder app)
        {
            HttpConfiguration httpConfig = new HttpConfiguration();

            ConfigureOAuthTokenGeneration(app);

            ConfigureWebApi(httpConfig);

            app.UseCors(Microsoft.Owin.Cors.CorsOptions.AllowAll);

            app.UseWebApi(httpConfig);

        }

        private void ConfigureOAuthTokenGeneration(IAppBuilder app)
        {
          

        }

        private void ConfigureWebApi(HttpConfiguration config)
        {
          config.MapHttpAttributeRoutes();
          var container = UnityConfig.GetConfiguredContainer();

          var resolver = new UnityDependencyResolver(container);
            config.DependencyResolver = resolver;



            var jsonFormatter = config.Formatters.OfType<JsonMediaTypeFormatter>().First();
            jsonFormatter.SerializerSettings.ContractResolver = new CamelCasePropertyNamesContractResolver();
        }
    }
}