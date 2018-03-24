using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;

namespace FirstAspNetCoreApp
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(
          IApplicationBuilder app,
          IHostingEnvironment env,
          ILoggerFactory loggerFactory)
        {

      //loggerFactory.AddConsole();

      if (env.IsDevelopment())
      {
        app.UseDeveloperExceptionPage();
      }

      // install nuget staticfiles pkg and add this code.. so we can serve etc. index.html from: wwwroot
      // the order matters.. we dont want to add this code after the throw error block etc
      app.UseDefaultFiles();
      app.UseStaticFiles();

      app.Run((context) =>
      {
        // await context.Response.WriteAsync("Hello World! 123");
        throw new Exception(); // it is not async.. so RM async keyword from fn
      });
    }
    }
}
