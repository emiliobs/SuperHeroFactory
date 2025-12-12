using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using SuperHero.UI.Clients;

namespace SuperHero.UI
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            var builder = WebAssemblyHostBuilder.CreateDefault(args);
            builder.RootComponents.Add<App>("#app");
            builder.RootComponents.Add<HeadOutlet>("head::after");

            var apiURL = "https://localhost:7058/";

            builder.Services.AddScoped(sp => new HttpClient
            {
                BaseAddress = new Uri(apiURL)
            });

            builder.Services.AddScoped<ISuperHeroApiClient, SuperHeroApiClient>();

            await builder.Build().RunAsync();
        }
    }
}