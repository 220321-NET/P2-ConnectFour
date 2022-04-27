using Microsoft.AspNetCore.Mvc;
using Model;
using DL;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Connect4API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BoardController : ControllerBase
    {
        private readonly ILogger<BoardController> _logger;

        private readonly IDBRepo _dl;

        public BoardController(IDBRepo dl, ILogger<BoardController> logger)
        {
            _dl = dl;
            _logger = logger;
        }

        // GET api/<ValuesController>/5
        [HttpGet("{LobbyId}")]
        public Board Get(int lobbyId)
        {
            return _dl.GetBoard(lobbyId);
        }

        // POST api/<ValuesController>
        [HttpPost]
        public Board Post(Board board)
        {
            return _dl.CreateBoard(board);
        }

        [HttpPut]
        public void Put(Board board)
        {
            _dl.UpdateBoard(board);
        }
    }
}
