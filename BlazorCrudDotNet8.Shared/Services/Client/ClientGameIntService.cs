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

    public Task<List<GameInt>> GetAllAsync()
    {
        throw new NotImplementedException();
    }
}
