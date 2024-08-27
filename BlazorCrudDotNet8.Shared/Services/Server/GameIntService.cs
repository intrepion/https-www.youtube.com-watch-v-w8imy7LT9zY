using BlazorCrudDotNet8.Shared.Data;
using BlazorCrudDotNet8.Shared.Entities;
using BlazorCrudDotNet8.Shared.Services.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace BlazorCrudDotNet8.Shared.Services.Server;

public class GameIntService(ApplicationDbContext applicationDbContext) : IGameIntService
{
    private readonly ApplicationDbContext _applicationDbContext = applicationDbContext;

    public async Task<GameInt> AddAsync(GameInt gameInt)
    {
        _applicationDbContext.GameInts.Add(gameInt);
        await _applicationDbContext.SaveChangesAsync();

        return gameInt;
    }

    public async Task<List<GameInt>> GetAllAsync()
    {
        await Task.Delay(1000);

        var gameInts = await _applicationDbContext.GameInts.ToListAsync();

        return gameInts;
    }
}
