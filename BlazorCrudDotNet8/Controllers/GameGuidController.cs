using BlazorCrudDotNet8.Shared.Entities;
using BlazorCrudDotNet8.Shared.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace BlazorCrudDotNet8.Controllers;

[Route("api/[controller]")]
[ApiController]
public class GameGuidController(IGameGuidService gameGuidService) : ControllerBase
{
    private readonly IGameGuidService _gameGuidService = gameGuidService;

    [HttpPost]
    public async Task<ActionResult<GameGuid>> Add(GameGuid gameGuid)
    {
        var addedGame = await _gameGuidService.AddAsync(gameGuid);

        return Ok(addedGame);
    }

    [HttpDelete("{id}")]
    public async Task<ActionResult<GameGuid>> Delete(Guid id)
    {
        var result = await _gameGuidService.DeleteAsync(id);

        return Ok(result);
    }

    [HttpPut("{id}")]
    public async Task<ActionResult<GameGuid>> Edit(Guid id, GameGuid gameGuid)
    {
        var updatedGame = await _gameGuidService.EditAsync(id, gameGuid);

        return Ok(updatedGame);
    }

    [HttpGet]
    public async Task<ActionResult<GameGuid>> GetAll()
    {
        var games = await _gameGuidService.GetAllAsync();

        return Ok(games);
    }

    [HttpGet("{id}")]
    public async Task<ActionResult<GameGuid>> GetById(Guid id)
    {
        var game = await _gameGuidService.GetByIdAsync(id);

        return Ok(game);
    }
}
