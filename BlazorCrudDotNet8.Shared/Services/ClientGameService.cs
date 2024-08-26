using System.Net.Http.Json;
using BlazorCrudDotNet8.Shared.Entities;

namespace BlazorCrudDotNet8.Shared.Services;

public class ClientGameService(HttpClient httpClient) : IGameService
{
    private readonly HttpClient _httpClient = httpClient;

    public async Task<Game> AddAsync(Game game)
    {
        var result = await _httpClient
            .PostAsJsonAsync("/api/game", game);

        return await result.Content.ReadFromJsonAsync<Game>();
    }

    public async Task<bool> DeleteAsync(Guid id)
    {
        var result = await _httpClient.DeleteAsync($"/api/game/{id}");

        return await result.Content.ReadFromJsonAsync<bool>();
    }

    public async Task<Game> EditAsync(Guid id, Game game)
    {
        var result = await _httpClient.PutAsJsonAsync($"/api/game/{id}", game);

        return await result.Content.ReadFromJsonAsync<Game>();
    }

    public Task<List<Game>> GetAllAsync()
    {
        throw new NotImplementedException();
    }

    public async Task<Game> GetByIdAsync(Guid id)
    {
        var result = await _httpClient
            .GetFromJsonAsync<Game>($"/api/game/{id}");

        return result;
    }
}
