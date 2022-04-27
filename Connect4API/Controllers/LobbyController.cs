using Microsoft.AspNetCore.Mvc;
using Model;
using DL;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Connect4API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LobbyController : ControllerBase
    {
        private readonly ILogger<LobbyController> _logger;

        private readonly IDBRepo _dl;

        public LobbyController(IDBRepo dl, ILogger<LobbyController> logger)
        {
            _dl = dl;
            _logger = logger;
        }

        // POST api/<LobbyController>
        [HttpPost]
        public Lobby Post(Lobby lobbyToCreate)
        {
            return _dl.CreateLobby(lobbyToCreate);
        }
    }
}
