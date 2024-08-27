using BlazorCrudDotNet8.Shared.Entities;
using BlazorCrudDotNet8.Shared.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace BlazorCrudDotNet8.Controllers;

[Route("api/[controller]")]
[ApiController]
public class GameStringController(IGameStringService gameStringService) : ControllerBase
{
    private readonly IGameStringService _gameStringService = gameStringService;

    [HttpPost]
    public async Task<ActionResult<GameString>> Add(GameString gameString)
    {
        var addedGame = await _gameStringService.AddAsync(gameString);

        return Ok(addedGame);
    }

    [HttpDelete("{id}")]
    public async Task<ActionResult<GameString>> Delete(string id)
    {
        var result = await _gameStringService.DeleteAsync(id);

        return Ok(result);
    }

    [HttpPut("{id}")]
    public async Task<ActionResult<GameString>> Edit(string id, GameString gameString)
    {
        var updatedGame = await _gameStringService.EditAsync(id, gameString);

        return Ok(updatedGame);
    }

    [HttpGet]
    public async Task<ActionResult<GameString>> GetAll()
    {
        var games = await _gameStringService.GetAllAsync();

        return Ok(games);
    }

    [HttpGet("{id}")]
    public async Task<ActionResult<GameString>> GetById(string id)
    {
        var game = await _gameStringService.GetByIdAsync(id);

        return Ok(game);
    }
}
