using BlazorCrudDotNet8.Data;
using BlazorCrudDotNet8.Entities;
using BlazorCrudDotNet8.Services.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace BlazorCrudDotNet8.Services.Server;

public class GameStringService(ApplicationDbContext applicationDbContext) : IGameStringService
{
    private readonly ApplicationDbContext _applicationDbContext = applicationDbContext;

    public async Task<List<GameString>> GetAllAsync()
    {
        await Task.Delay(1000);

        var gameStrings = await _applicationDbContext.GameStrings.ToListAsync();

        return gameStrings;
    }
}
