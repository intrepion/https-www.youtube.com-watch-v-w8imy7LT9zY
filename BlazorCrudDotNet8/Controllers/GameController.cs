using BlazorCrudDotNet8.BusinessLogic.Entities;
using BlazorCrudDotNet8.BusinessLogic.Services;
using Microsoft.AspNetCore.Mvc;

namespace BlazorCrudDotNet8.Controllers;

[Route("api/[controller]")]
[ApiController]

public class GameController(IGameService gameService) : ControllerBase
{
    private readonly IGameService _gameService = gameService;

    [HttpGet("{id}")]
    public async Task<ActionResult<Game>> GetGameById(int id)
    {
        var game = await _gameService.GetGameById(id);

        return Ok(game);
    }

    [HttpPost]
    public async Task<ActionResult<Game>> AddGames(Game game)
    {
        var addedGame = await _gameService.AddGame(game);

        return Ok(addedGame);
    }

    [HttpPut("{id}")]
    public async Task<ActionResult<Game>> EditGame(int id, Game game)
    {
        var updatedGame = await _gameService.EditGame(id, game);

        return Ok(updatedGame);
    }

    [HttpDelete("{id}")]
    public async Task<ActionResult<bool>> DeleteGame(int id)
    {
        var result = await _gameService.DeleteGame(id);

        return Ok(result);
    }
}
