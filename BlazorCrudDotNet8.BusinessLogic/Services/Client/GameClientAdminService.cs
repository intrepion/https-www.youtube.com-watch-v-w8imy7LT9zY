using System.Net.Http.Json;
using ApplicationNamePlaceholder.BusinessLogic.Entities;

namespace ApplicationNamePlaceholder.BusinessLogic.Services.Client;

public class GameClientAdminService(HttpClient httpClient) : IGameAdminService
{
    private readonly HttpClient _httpClient = httpClient;

    public async Task<Game?> AddAsync(string userName, Game EntityLowercaseNamePlaceholder)
    {
        var result = await _httpClient.PostAsJsonAsync("/api/GameAdmin", EntityLowercaseNamePlaceholder);

        return await result.Content.ReadFromJsonAsync<Game>();
    }

    public async Task<bool> DeleteAsync(string userName, Guid id)
    {
        var result = await _httpClient.DeleteAsync($"/api/GameAdmin/{id}");

        return await result.Content.ReadFromJsonAsync<bool>();
    }

    public async Task<Game?> EditAsync(string userName, Guid id, Game EntityLowercaseNamePlaceholder)
    {
        var result = await _httpClient.PutAsJsonAsync($"/api/GameAdmin/{id}", EntityLowercaseNamePlaceholder);

        return await result.Content.ReadFromJsonAsync<Game>();
    }

    public async Task<List<Game>?> GetAllAsync()
    {
        var result = await _httpClient.GetFromJsonAsync<List<Game>>("/api/GameAdmin");

        return result;
    }

    public async Task<Game?> GetByIdAsync(Guid id)
    {
        var result = await _httpClient.GetFromJsonAsync<Game>($"/api/GameAdmin/{id}");

        return result;
    }
}
