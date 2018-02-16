using System.Web.Http;
using WebActivatorEx;
using Ninject.WebApi;
using Swashbuckle.Application;

[assembly: PreApplicationStartMethod(typeof(SwaggerConfig), "Register")]

namespace Ninject.WebApi
{
    public class SwaggerConfig
    {
        public static void Register()
        {
            var thisAssembly = typeof(SwaggerConfig).Assembly;

            GlobalConfiguration.Configuration
                .EnableSwagger(c =>
                    {
                        c.SingleApiVersion("v1", "Ninject.WebApi");

                    })
                .EnableSwaggerUi(c =>
                    {
                    });
        }
    }
}
