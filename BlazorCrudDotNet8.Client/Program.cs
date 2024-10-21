using BlazorCrudDotNet8.BusinessLogic.Repositories.Admin;
using BlazorCrudDotNet8.BusinessLogic.Repositories.Admin.Client;
using BlazorCrudDotNet8.Client;
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
builder.Services.AddScoped<IApplicationRoleAdminRepository, ApplicationRoleClientAdminRepository>();
builder.Services.AddScoped<IApplicationUserAdminRepository, ApplicationUserClientAdminRepository>();

builder.Services.AddScoped<IGameAdminRepository, GameClientAdminRepository>();
// RegisterClientServiceCodePlaceholder

await builder.Build().RunAsync();
