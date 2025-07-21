// Ruta: CreditApp.BlazorClient/Program.cs

using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using CreditApp.BlazorClient;
 
using System.Net.Http.Headers;
using System.Text.Json;
using System.Text.Json.Serialization;

var builder = WebAssemblyHostBuilder.CreateDefault(args);

 
builder.Services.AddSingleton(new JsonSerializerOptions
{
    Converters = { new JsonStringEnumConverter() },
    NumberHandling = JsonNumberHandling.AllowReadingFromString
});

builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

 
builder.Services.AddScoped(sp =>
{
    var client = new HttpClient { BaseAddress = new Uri("http://localhost:5176/") };
    client.DefaultRequestHeaders.Accept.Add(
        new MediaTypeWithQualityHeaderValue("application/json"));
    return client;
});
 
builder.Services.AddScoped<ISolicitudCreditoService, SolicitudCreditoService>();
builder.Services.AddScoped<SolicitudCreditoViewModel>();

await builder.Build().RunAsync();
