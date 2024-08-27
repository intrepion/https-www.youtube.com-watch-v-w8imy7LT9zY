using System.Net.Http.Json;
using BlazorCrudDotNet8.Shared.Entities;
using BlazorCrudDotNet8.Shared.Services.Interfaces;

namespace BlazorCrudDotNet8.Shared.Services.Client;

public class ClientApplicationUserService(HttpClient httpClient) : IApplicationUserService
{
    private readonly HttpClient _httpClient = httpClient;

    public async Task<ApplicationUser> AddAsync(ApplicationUser applicationUser)
    {
        var result = await _httpClient.PostAsJsonAsync("/api/applicationUser", applicationUser);

        return await result.Content.ReadFromJsonAsync<ApplicationUser>();
    }

    public async Task<bool> DeleteAsync(string id)
    {
        var result = await _httpClient.DeleteAsync($"/api/applicationUser/{id}");

        return await result.Content.ReadFromJsonAsync<bool>();
    }

    public async Task<ApplicationUser> EditAsync(string id, ApplicationUser applicationUser)
    {
        var result = await _httpClient.PutAsJsonAsync($"/api/applicationUser/{id}", applicationUser);

        return await result.Content.ReadFromJsonAsync<ApplicationUser>();
    }

    public async Task<List<ApplicationUser>> GetAllAsync()
    {
        var result = await _httpClient.GetFromJsonAsync<List<ApplicationUser>>("/api/applicationUser");

        return result;
    }

    public async Task<ApplicationUser> GetByIdAsync(string id)
    {
        var result = await _httpClient.GetFromJsonAsync<ApplicationUser>($"/api/applicationUser/{id}");

        return result;
    }
}
