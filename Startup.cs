using Microsoft.AspNet.Builder;
using Microsoft.AspNet.StaticFiles;
using Microsoft.AspNet.Routing;
using Microsoft.Framework.DependencyInjection;
using System;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace RipGac
{
  using AppFunc = Func<IDictionary<string, object>, Task>;
  using AddMiddleware = Action<Func<
          Func<IDictionary<string, object>, Task>,
          Func<IDictionary<string, object>, Task>
        >>;
        
  public class Startup
  {
    public void Configure(IBuilder app)
    {
      AddMiddleware use = app.UseOwin();
      use(Test);
      app.UseStaticFiles();
      app.UseServices(services => 
      {
        services.AddMvc();
      });
      app.UseMvc(routes =>
      {
        routes.MapRoute(
          name: "Default",
          template: "{controller}/{action}/{id?}",
          defaults: new { controller = "Home", action = "Index" });
      });
    }

    public AppFunc Test(AppFunc next)
    {
      return async env =>
      {
        try
        {
          await next(env);
        }      
        catch (Exception ex)
        {
          Console.WriteLine(ex.ToString());
          throw;
        }
      };
    }
  }
}