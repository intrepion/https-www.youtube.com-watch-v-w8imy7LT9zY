using BlazorCrudDotNet8.Shared.Entities;
using BlazorCrudDotNet8.Shared.Services;
using Microsoft.AspNetCore.Mvc;

namespace BlazorCrudDotNet8.Controllers;

[Route("api/[controller]")]
[ApiController]
public class GameController(IGameService gameService) : ControllerBase
{
    private readonly IGameService _gameService = gameService;

    [HttpPost]
    public async Task<ActionResult<Game>> Add(Game game)
    {
        var addedGame = await _gameService.AddAsync(game);

        return Ok(addedGame);
    }

    [HttpDelete("{id}")]
    public async Task<ActionResult<Game>> Delete(Guid id)
    {
        var result = await _gameService.DeleteAsync(id);

        return Ok(result);
    }

    [HttpPut("{id}")]
    public async Task<ActionResult<Game>> Edit(Guid id, Game game)
    {
        var updatedGame = await _gameService.EditAsync(id, game);

        return Ok(updatedGame);
    }

    [HttpGet]
    public async Task<ActionResult<Game>> GetById(Guid id)
    {
        var game = await _gameService.GetByIdAsync(id);

        return Ok(game);
    }
}
