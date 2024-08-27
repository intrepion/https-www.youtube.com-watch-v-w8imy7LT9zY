using System.Net.Http.Json;
using BlazorCrudDotNet8.Shared.Entities;
using BlazorCrudDotNet8.Shared.Services.Interfaces;

namespace BlazorCrudDotNet8.Shared.Services.Client;

public class ClientGameStringService(HttpClient httpClient) : IGameStringService
{
    private readonly HttpClient _httpClient = httpClient;

    public async Task<GameString> AddAsync(GameString gameString)
    {
        var result = await _httpClient.PostAsJsonAsync("/api/gameString", gameString);

        return await result.Content.ReadFromJsonAsync<GameString>();
    }

    public Task<List<GameString>> GetAllAsync()
    {
        throw new NotImplementedException();
    }
}
