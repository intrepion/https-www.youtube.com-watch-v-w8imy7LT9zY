using BlazorCrudDotNet8.Shared.Data;
using BlazorCrudDotNet8.Shared.Entities;
using BlazorCrudDotNet8.Shared.Services.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace BlazorCrudDotNet8.Shared.Services.Server;

public class GameGuidService(ApplicationDbContext applicationDbContext) : IGameGuidService
{
    private readonly ApplicationDbContext _applicationDbContext = applicationDbContext;

    public async Task<GameGuid> AddAsync(GameGuid gameGuid)
    {
        _applicationDbContext.GameGuids.Add(gameGuid);
        await _applicationDbContext.SaveChangesAsync();

        return gameGuid;
    }

    public async Task<List<GameGuid>> GetAllAsync()
    {
        await Task.Delay(1000);

        var gameGuids = await _applicationDbContext.GameGuids.ToListAsync();

        return gameGuids;
    }
}
