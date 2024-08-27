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

    public Task<List<GameGuid>> GetAllAsync()
    {
        throw new NotImplementedException();
    }
}
