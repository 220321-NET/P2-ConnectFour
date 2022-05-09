using Model;
using DL;
using Microsoft.AspNetCore.Mvc;

namespace Connect4API.Controllers;

[ApiController]
[Route("api/[controller]")]
public class RankingController : ControllerBase
{
    private readonly ILogger<RankingController> _logger;
    private readonly IDBRepo _dl;

    public RankingController(IDBRepo dl, ILogger<RankingController> logger)
    {
        _dl = dl;
        _logger = logger;
    }

    // GET: api/<RankingController>
    [HttpGet("GetPlayerRank/{playerId}")]
    public int Get(int playerId)
    {
        return _dl.GetPlayerRank(playerId);
    }

    [HttpGet("GetAllPlayerRanks")]
    public List<Ranking> GetAll() {
        return _dl.GetAllPlayerRanks();
    }

    // PUT api/<RankingController>/Player Object
    [HttpPut]
    public void Put([FromBody] Ranking rankToUpdate)
    {
        _dl.UpdateRank(rankToUpdate);
    }
}

