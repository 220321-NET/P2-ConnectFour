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
    [HttpGet("GetPlayerRank")]
    public int Get(Player playerRank)
    {
        return _dl.GetPlayerRank(playerRank);
    }

    [HttpGet("GetAllPlayerRanks")]
    public List<Ranking> GetAll() {
        return _dl.GetAllPlayerRanks();
    }

    // // POST api/<RankingController>
    // [HttpPost]
    // public void Post([FromBody] string value)
    // {
    //      # Might be implemented in a player controller due to rank record creation is tied to a Player Property
    // }

    // PUT api/<RankingController>/Player Object
    [HttpPut]
    public void Put([FromBody] Ranking rankToUpdate)
    {
        _dl.UpdateRank(rankToUpdate);
    }
}

