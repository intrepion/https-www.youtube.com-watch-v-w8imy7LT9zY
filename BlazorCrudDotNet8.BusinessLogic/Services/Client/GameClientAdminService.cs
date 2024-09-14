using System.Net.Http.Json;
using BlazorCrudDotNet8.BusinessLogic.Entities;
using BlazorCrudDotNet8.BusinessLogic.Entities.DataTransferObjects;

namespace BlazorCrudDotNet8.BusinessLogic.Services.Client;

public class GameClientAdminService(HttpClient httpClient) : IGameAdminService
{
    private readonly HttpClient _httpClient = httpClient;

    public async Task<Game?> AddAsync(string userName, Game game)
    {
        var result = await _httpClient.PostAsJsonAsync("/api/GameAdmin", game);

        return await result.Content.ReadFromJsonAsync<Game>();
    }

    public async Task<bool> DeleteAsync(string userName, Guid id)
    {
        var result = await _httpClient.DeleteAsync($"/api/GameAdmin/{id}");

        return await result.Content.ReadFromJsonAsync<bool>();
    }

    public async Task<Game?> EditAsync(string userName, Guid id, Game game)
    {
        var result = await _httpClient.PutAsJsonAsync($"/api/GameAdmin/{id}", game);

        return await result.Content.ReadFromJsonAsync<Game>();
    }

    public async Task<List<Game>?> GetAllAsync()
    {
        var result = await _httpClient.GetFromJsonAsync<List<Game>>("/api/GameAdmin");

        return result;
    }

    public async Task<Game?> GetByIdAsync(Guid id)
    {
        var result = await _httpClient.GetFromJsonAsync<Game>($"/api/GameAdmin/{id}");

        return result;
    }

    public Task<int> GetCountAsync(CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task<IEnumerable<GameAdminDataTransferObject>> GetDataFragmentAsync(int startIndex, int? count, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

}
