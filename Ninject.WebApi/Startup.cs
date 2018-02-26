using Microsoft.Owin;
using Owin;
using Serilog;
using System;

[assembly: OwinStartup(typeof(Ninject.WebApi.Startup))]

namespace Ninject.WebApi
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            string basedir = AppDomain.CurrentDomain.BaseDirectory;


            Log.Logger = new LoggerConfiguration()
              .MinimumLevel.Verbose()
              .WriteTo.RollingFile(basedir + "/log.txt")
              .CreateLogger();

            Log.Information("Hello, world!");

        }
    }
}
