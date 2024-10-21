using System.Net.Http.Json;
using ApplicationNamePlaceholder.BusinessLogic.Entities.Dtos.Admin;

namespace ApplicationNamePlaceholder.BusinessLogic.Repositories.Admin.Client;

public class GameClientAdminRepository(HttpClient httpClient) : IGameAdminRepository
{
    private readonly HttpClient _httpClient = httpClient;

    public async Task<GameAdminDto?> AddAsync(GameAdminDto gameAdminDto)
    {
        var result = await _httpClient.PostAsJsonAsync("/api/admin/gameAdmin", gameAdminDto);

        return await result.Content.ReadFromJsonAsync<GameAdminDto>();
    }

    public async Task<bool> DeleteAsync(string userName, Guid id)
    {
        var result = await _httpClient.DeleteAsync($"/api/admin/gameAdmin/{id}?userName={userName}");

        return await result.Content.ReadFromJsonAsync<bool>();
    }

    public async Task<GameAdminDto?> EditAsync(GameAdminDto gameAdminDto)
    {
        var result = await _httpClient.PutAsJsonAsync($"/api/admin/gameAdmin/{gameAdminDto.Id}", gameAdminDto);

        return await result.Content.ReadFromJsonAsync<GameAdminDto>();
    }

    public async Task<List<GameAdminDto>?> GetAllAsync(string userName)
    {
        var result = await _httpClient.GetFromJsonAsync<List<GameAdminDto>>($"/api/admin/gameAdmin?userName={userName}");

        return result;
    }

    public async Task<GameAdminDto?> GetByIdAsync(string userName, Guid id)
    {
        var result = await _httpClient.GetFromJsonAsync<GameAdminDto>($"/api/admin/gameAdmin/{id}?userName={userName}");

        return result;
    }
}
