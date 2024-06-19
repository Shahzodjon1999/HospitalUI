using BlazorDownloadFile;
using Blazored.SessionStorage;
using Blazorise;
using HospitalWeb;
using HospitalWeb.Authentication;
using HospitalWeb.Extentions;
using HospitalWeb.Services;
using Microsoft.AspNetCore.Components.Authorization;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using MudBlazor.Services;
using Syncfusion.Blazor;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri("http://localhost:5224/") });

builder.Services.AddAuthorizationCore();
builder.Services.AddBlazoredSessionStorage();
builder.Services.AddScoped<AuthenticationStateProvider, CustomAuthenticationStateProvider>();
builder.Services.AddScoped<CustomAuthenticationStateProvider>();

//added Dashboeard service
builder.Services.AddScoped<DashboardService>();
//added
builder.Services.AddBlazorise();
//added for design
builder.Services.AddSyncfusionBlazor();

//added for MudBlazor
builder.Services.AddMudServices();

// Register BlazorDownloadFile service
builder.Services.AddBlazorDownloadFile();

//added TimerService for Background service
builder.Services.AddSingleton<TimerService>();

await builder.Build().RunAsync();
