using System.Net.Http.Json;
using BlazorCrudDotNet8.Shared.Entities;
using BlazorCrudDotNet8.Shared.Services.Interfaces;

namespace BlazorCrudDotNet8.Shared.Services.Client;

public class ClientGameIntService(HttpClient httpClient) : IGameIntService
{
    private readonly HttpClient _httpClient = httpClient;

    public async Task<GameInt> AddAsync(GameInt gameInt)
    {
        var result = await _httpClient.PostAsJsonAsync("/api/gameInt", gameInt);

        return await result.Content.ReadFromJsonAsync<GameInt>();
    }

    public async Task<bool> DeleteAsync(int id)
    {
        var result = await _httpClient.DeleteAsync($"/api/gameInt/{id}");

        return await result.Content.ReadFromJsonAsync<bool>();
    }

    public async Task<GameInt> EditAsync(int id, GameInt gameInt)
    {
        var result = await _httpClient.PutAsJsonAsync($"/api/gameInt/{id}", gameInt);

        return await result.Content.ReadFromJsonAsync<GameInt>();
    }

    public Task<List<GameInt>> GetAllAsync()
    {
        throw new NotImplementedException();
    }

    public async Task<GameInt> GetByIdAsync(int id)
    {
        var result = await _httpClient.GetFromJsonAsync<GameInt>($"/api/gameInt/{id}");

        return result;
    }
}
