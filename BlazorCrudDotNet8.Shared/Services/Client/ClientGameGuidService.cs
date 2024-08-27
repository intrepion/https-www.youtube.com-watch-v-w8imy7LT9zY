using System.Net.Http.Json;
using BlazorCrudDotNet8.Shared.Entities;
using BlazorCrudDotNet8.Shared.Services.Interfaces;

namespace BlazorCrudDotNet8.Shared.Services.Client;

public class ClientGameGuidService(HttpClient httpClient) : IGameGuidService
{
    private readonly HttpClient _httpClient = httpClient;

    public async Task<GameGuid> AddAsync(GameGuid gameGuid)
    {
        var result = await _httpClient.PostAsJsonAsync("/api/gameGuid", gameGuid);

        return await result.Content.ReadFromJsonAsync<GameGuid>();
    }

    public async Task<bool> DeleteAsync(Guid id)
    {
        var result = await _httpClient.DeleteAsync($"/api/gameGuid/{id}");

        return await result.Content.ReadFromJsonAsync<bool>();
    }

    public async Task<GameGuid> EditAsync(Guid id, GameGuid gameGuid)
    {
        var result = await _httpClient.PutAsJsonAsync($"/api/gameGuid/{id}", gameGuid);

        return await result.Content.ReadFromJsonAsync<GameGuid>();
    }

    public async Task<List<GameGuid>> GetAllAsync()
    {
        var result = await _httpClient.GetFromJsonAsync<List<GameGuid>>("/api/gameGuid");

        return result;
    }

    public async Task<GameGuid> GetByIdAsync(Guid id)
    {
        var result = await _httpClient.GetFromJsonAsync<GameGuid>($"/api/gameGuid/{id}");

        return result;
    }
}
