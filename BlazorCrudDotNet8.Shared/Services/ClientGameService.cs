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

    public Task<List<Game>> GetAllAsync()
    {
        throw new NotImplementedException();
    }
}
