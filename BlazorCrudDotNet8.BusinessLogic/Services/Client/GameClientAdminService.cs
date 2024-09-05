using System.Net.Http.Json;
using ApplicationNamePlaceholder.BusinessLogic.Entities;

namespace ApplicationNamePlaceholder.BusinessLogic.Services.Client;

public class GameClientAdminService(HttpClient httpClient) : IGameAdminService
{
    private readonly HttpClient _httpClient = httpClient;

    public async Task<Game?> AddAsync(string userName, Game LowercaseNamePlaceholder)
    {
        var result = await _httpClient.PostAsJsonAsync("/api/Game", LowercaseNamePlaceholder);

        return await result.Content.ReadFromJsonAsync<Game>();
    }

    public async Task<bool> DeleteAsync(string userName, Guid id)
    {
        var result = await _httpClient.DeleteAsync($"/api/Game/{id}");

        return await result.Content.ReadFromJsonAsync<bool>();
    }

    public async Task<Game?> EditAsync(string userName, Guid id, Game LowercaseNamePlaceholder)
    {
        var result = await _httpClient.PutAsJsonAsync($"/api/Game/{id}", LowercaseNamePlaceholder);

        return await result.Content.ReadFromJsonAsync<Game>();
    }

    public async Task<List<Game>?> GetAllAsync()
    {
        var result = await _httpClient.GetFromJsonAsync<List<Game>>("/api/Game");

        return result;
    }

    public async Task<Game?> GetByIdAsync(Guid id)
    {
        var result = await _httpClient.GetFromJsonAsync<Game>($"/api/Game/{id}");

        return result;
    }
}
