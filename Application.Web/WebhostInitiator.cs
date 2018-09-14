using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Application.Web
{
    public static class WebhostInitiator
    {
        public static void RunWebHost(string[] args)
        {
            
            var config = new ConfigurationBuilder()
                .AddJsonFile("appsettings.json", true)
                .Build();

            IWebHost webHost = WebHost.CreateDefaultBuilder(args)
                .UseConfiguration(config)
                .UseStartup<Startup>()
                .UseKestrel()
                .Build();
            webHost.Run();
        }
    }
}
