using BlazorCrudDotNet8.Client;
using BlazorCrudDotNet8.Shared.Services.Client;
using BlazorCrudDotNet8.Shared.Services.Interfaces;
using Microsoft.AspNetCore.Components.Authorization;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;

var builder = WebAssemblyHostBuilder.CreateDefault(args);

builder.Services.AddAuthorizationCore();
builder.Services.AddCascadingAuthenticationState();
builder.Services.AddSingleton<AuthenticationStateProvider, PersistentAuthenticationStateProvider>();

builder.Services.AddScoped(http => new HttpClient
{
    BaseAddress = new Uri(builder.HostEnvironment.BaseAddress),
});

builder.Services.AddScoped<IApplicationUserService, ClientApplicationUserService>();
builder.Services.AddScoped<IGameGuidService, ClientGameGuidService>();
builder.Services.AddScoped<IGameIntService, ClientGameIntService>();
builder.Services.AddScoped<IGameStringService, ClientGameStringService>();

await builder.Build().RunAsync();
