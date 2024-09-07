﻿using System.Net.Http.Json;
using BlazorCrudDotNet8.BusinessLogic.Entities;

namespace BlazorCrudDotNet8.BusinessLogic.Services.Client;

public class ApplicationRoleClientAdminService(HttpClient httpClient) : IApplicationRoleAdminService
{
    private readonly HttpClient _httpClient = httpClient;

    public async Task<ApplicationRole?> AddAsync(string userName, ApplicationRole applicationRole)
    {
        var result = await _httpClient.PostAsJsonAsync("/api/ApplicationRole", applicationRole);

        return await result.Content.ReadFromJsonAsync<ApplicationRole>();
    }

    public async Task<bool> DeleteAsync(string userName, Guid id)
    {
        var result = await _httpClient.DeleteAsync($"/api/ApplicationRole/{id}");

        return await result.Content.ReadFromJsonAsync<bool>();
    }

    public async Task<ApplicationRole?> EditAsync(string userName, Guid id, ApplicationRole applicationRole)
    {
        var result = await _httpClient.PutAsJsonAsync($"/api/ApplicationRole/{id}", applicationRole);

        return await result.Content.ReadFromJsonAsync<ApplicationRole>();
    }

    public async Task<List<ApplicationRole>?> GetAllAsync()
    {
        var result = await _httpClient.GetFromJsonAsync<List<ApplicationRole>>("/api/ApplicationRole");

        return result;
    }

    public async Task<ApplicationRole?> GetByIdAsync(Guid id)
    {
        var result = await _httpClient.GetFromJsonAsync<ApplicationRole>($"/api/ApplicationRole/{id}");

        return result;
    }
}
