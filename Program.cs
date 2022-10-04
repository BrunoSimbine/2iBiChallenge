using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using ClientApp;
using ClientApp.Services;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");
builder.Services.AddScoped<ICountryService, CountryService>();
builder.Services.AddScoped<IXMLService, XMLService>();
builder.Services.AddScoped<ICSVService, CSVService>();
builder.Services.AddScoped<IXLSService, XLSService>();
builder.Services.AddScoped<IDownloadService, DownloadService>();
builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });
var app = builder.Build().RunAsync();