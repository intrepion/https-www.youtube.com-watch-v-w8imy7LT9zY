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

    public async Task<bool> DeleteGame(int id)
    {
        var result = await _httpClient.DeleteAsync($"/api/game/{id}");

        return await result.Content.ReadFromJsonAsync<bool>();
    }

    public async Task<Game> EditGame(int id, Game game)
    {
        var result = await _httpClient.PutAsJsonAsync<Game>($"/api/game/{id}", game);

        return await result.Content.ReadFromJsonAsync<Game>();
    }

    public Task<List<Game>> GetAllGames()
    {
        throw new NotImplementedException();
    }

    public async Task<Game> GetGameById(int id)
    {
        var result = await _httpClient.GetFromJsonAsync<Game>($"/api/game/{id}");

        return result;
    }
}
