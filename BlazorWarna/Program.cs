using BlazorWarna;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using System.Globalization;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

// # contoh bagus DI https://blazorschool.com/ ;;; https://blazorschool.com/tutorial/blazor-wasm/dotnet6/dependency-injection-117612
// # https://blazorschool.com/tutorial/blazor-server/dotnet5/dependency-injection-478834

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });
//builder.Services.AddHttpClient();

// this 1 :
//builder.Services.AddTransient <IBioServices> (x => new BioServices(1));
// or this 2 :
builder.Services.AddTransient<IBioServices,BioServices>(x => new (1, 10001)); 
builder.Services.AddScoped<IBetterBioSer ,BetterBioSer>(v => new (20,30));

// region :   //  https://docs.microsoft.com/en-us/aspnet/core/blazor/globalization-localization?view=aspnetcore-6.0&pivots=server
CultureInfo.DefaultThreadCurrentCulture = new CultureInfo("id-ID");
CultureInfo.DefaultThreadCurrentUICulture = new CultureInfo("id-ID");

await builder.Build().RunAsync();