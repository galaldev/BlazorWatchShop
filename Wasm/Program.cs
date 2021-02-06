using System;
using System.Net.Http;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Text;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using WatchShop.Services;
using WatchShop.Tests.StateManagement._05StateContainer;

namespace WatchShop
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            var builder = WebAssemblyHostBuilder.CreateDefault(args);
            builder.RootComponents.Add<App>("#app");
            //builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });
            builder.Services.AddTransient(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });

            builder.Services.AddTransient<ProductService>();
            builder.Services.AddSingleton<WatchShop.Tests.StateManagement._05StateContainer.StateContainer>();
            builder.Services.AddSingleton<WatchShop.Tests.StateManagement._06StateContainerCustomProperties.StateContainer>();
            builder.Services.AddSingleton<WatchShop.Tests.StateManagement._07StateContainerBaseComponent.StateContainer>();
            builder.Services.AddSingleton<WatchShop.Tests.StateManagement._08StateContainerBaseComponentDontRenderParent.StateContainer>();

            await builder.Build().RunAsync();
        }
    }
}
