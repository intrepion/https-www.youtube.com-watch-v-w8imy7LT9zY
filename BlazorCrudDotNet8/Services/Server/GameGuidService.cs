﻿using BlazorCrudDotNet8.Data;
using BlazorCrudDotNet8.Entities;
using BlazorCrudDotNet8.Services.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace BlazorCrudDotNet8.Services.Server;

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
