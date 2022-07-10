using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myconsole
{
    public class Startup
    {


       
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllers();
        }
        public void Cofigure(IApplicationBuilder application,IWebHostEnvironment environment)
        {

            if (environment.IsDevelopment())
            {
                application.UseDeveloperExceptionPage();
            }
            application.UseRouting();
            application.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
