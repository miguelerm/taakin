using Microsoft.AspNetCore.Builder;

namespace Taakin.Api
{
    public class Startup
    {
        public void Configure(IApplicationBuilder app) {

            var options = new DefaultFilesOptions();
            options.DefaultFileNames.Clear();
            options.DefaultFileNames.Add("index.html");
            
            app.UseDefaultFiles(options);
            app.UseStaticFiles();
        }
    }    
}

