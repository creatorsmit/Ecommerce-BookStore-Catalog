// See https://aka.ms/new-console-template for more information
namespace myconsole {
    class Program { 
        public static void main(String[] args) {
            CreateHostBuilder(args).Build().Run();
     }
        public static IHostBuilder CreateHostBuilder(String[] args)=>
            
            Host.CreateDefaultBuilder(args).ConfigureWebHostDefaults(webHost =>
                {
                    webHost.UseStartup<Startup>();
                });
        

    }
}

