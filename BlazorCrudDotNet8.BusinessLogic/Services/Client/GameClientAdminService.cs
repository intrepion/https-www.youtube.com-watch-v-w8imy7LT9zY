using System.Net.Http.Json;
using ApplicationNamePlaceholder.BusinessLogic.Entities.DataTransferObjects;

namespace ApplicationNamePlaceholder.BusinessLogic.Services.Client;

public class GameClientAdminService(HttpClient httpClient) : IGameAdminService
{
    private readonly HttpClient _httpClient = httpClient;

    public async Task<GameAdminDataTransferObject?> AddAsync(string userName, GameAdminDataTransferObject gameAdminDataTransferObject)
    {
        var result = await _httpClient.PostAsJsonAsync("/api/admin/gameAdmin", gameAdminDataTransferObject);

        return await result.Content.ReadFromJsonAsync<GameAdminDataTransferObject>();
    }

    public async Task<bool> DeleteAsync(string userName, Guid id)
    {
        var result = await _httpClient.DeleteAsync($"/api/admin/gameAdmin/{id}");

        return await result.Content.ReadFromJsonAsync<bool>();
    }

    public async Task<GameAdminDataTransferObject?> EditAsync(string userName, Guid id, GameAdminDataTransferObject gameAdminDataTransferObject)
    {
        var result = await _httpClient.PutAsJsonAsync($"/api/admin/gameAdmin/{id}", gameAdminDataTransferObject);

        return await result.Content.ReadFromJsonAsync<GameAdminDataTransferObject>();
    }

    public async Task<List<GameAdminDataTransferObject>?> GetAllAsync()
    {
        var result = await _httpClient.GetFromJsonAsync<List<GameAdminDataTransferObject>>("/api/admin/gameAdmin");

        return result;
    }

    public async Task<GameAdminDataTransferObject?> GetByIdAsync(Guid id)
    {
        var result = await _httpClient.GetFromJsonAsync<GameAdminDataTransferObject>($"/api/admin/gameAdmin/{id}");

        return result;
    }
}
