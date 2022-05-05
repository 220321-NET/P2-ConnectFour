using Model;
using DL;
using Microsoft.AspNetCore.Mvc;

namespace Connect4API.Controllers;

[ApiController]
[Route("[controller]")]
public class PlayerController : ControllerBase
{
    private readonly ILogger<PlayerController> _logger;
    private readonly IDBRepo _dl;

    public PlayerController(IDBRepo dl, ILogger<PlayerController> logger)
    {
        _dl = dl;
        _logger = logger;
    }
    //Retrieves player profile before game
    [HttpGet("GetPlayer/{username}")]
    public Player Get(string username)
    {
        return _dl.GetPlayer(username);
    }

    [HttpGet("GetPlayerbyId/{playerid}")]
    public Player Get(int playerid)
    {
        return _dl.GetPlayerbyId(playerid);
    }

    //Retrieves leaderboard
    [HttpGet("GetAllPlayers")]
    public List<Player> GetAll()
    {
        return _dl.GetAllPlayers();
    }

    [HttpPost("AddPlayer")]
    public void Post(Player player)
    {
        _dl.CreatePlayer(player);
    }
}