using Model;
using DL;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Cors;

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

    [HttpGet("GetRank/{playerId}")]
    public Ranking GetRank(int playerId) {
        return _dl.GetFullRanking(playerId);
    }

    [HttpGet("GetAllPlayerRanks")]
    public List<Ranking> GetAll() {
        return _dl.GetAllPlayerRanks();
    }

    // PUT api/<RankingController>/Player Object
    [EnableCors("_myAllowSpecificOrigins")]
    [HttpPut]
    public void Put([FromBody] Ranking rankToUpdate)
    {
        _dl.UpdateRank(rankToUpdate);
    }
}

