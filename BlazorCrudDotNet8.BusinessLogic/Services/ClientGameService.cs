using System.Net.Http.Json;
using BlazorCrudDotNet8.BusinessLogic.Entities;

namespace BlazorCrudDotNet8.BusinessLogic.Services;

public class ClientGameService(HttpClient httpClient) : IGameService
{
    public readonly HttpClient _httpClient = httpClient;

    public async Task<Game> AddGame(Game game)
    {
        var result = await _httpClient.PostAsJsonAsync("/api/game", game);

        return await result.Content.ReadFromJsonAsync<Game>();
    }

    public Task<List<Game>> GetAllGames()
    {
        throw new NotImplementedException();
    }
}
