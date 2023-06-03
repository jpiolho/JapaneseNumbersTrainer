using Blazored.LocalStorage;
using CurrieTechnologies.Razor.SweetAlert2;
using JapaneseNumbersTrainer.Services;
using JapaneseNumbersTrainer.Services.Japanese;
using JapaneseNumbersTrainer.Services.Options;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;

namespace JapaneseNumbersTrainer
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            var builder = WebAssemblyHostBuilder.CreateDefault(args);
            builder.RootComponents.Add<App>("#app");
            builder.RootComponents.Add<HeadOutlet>("head::after");

            builder.Services.AddBlazoredLocalStorage();
            builder.Services.AddSweetAlert2();

            builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });

            builder.Services.AddScoped<JapaneseNumbersService>();
            builder.Services.AddScoped<JapaneseDateService>();
            builder.Services.AddScoped<JapaneseRomajiService>();

            builder.Services.AddScoped<OptionsService>();
            builder.Services.AddScoped<DialogsService>();
            builder.Services.AddScoped<NavigationService>();


            await builder.Build().RunAsync();
        }
    }
}