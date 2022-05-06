using Xunit;
using Model;
using Moq;
using Connect4API.Controllers;
using Microsoft.Extensions.Logging;
using DL;

namespace tests;

public class DBTests
{
    private readonly ILogger<PlayerController>_logger;
    
    public Mock<IDBRepo> mock = new Mock<IDBRepo>();

    [Fact]
    public void GetPlayerByUsername_PlayerExistsInRep()
    {
        Player checkPlayer = new Player()
        {
            PlayerID = 2,
            Email = "mendozaj9486@gmail.com",
            Username = "jxm8022",
            Password = "test",
            Wins = 0,
            Ties = 0,
            Losses = 0
        };

        mock.Setup(p => p.GetPlayer("jxm8022")).Returns(checkPlayer);
        PlayerController play = new PlayerController(mock.Object, _logger);
        Player result = play.Get("jxm8022");
        Assert.Equal(checkPlayer, result);
    }

    [Fact]
    public void GetPlayerById_PlayerExistsInRep()
    {
        Player checkPlayer = new Player()
        {
            PlayerID = 2,
            Email = "mendozaj9486@gmail.com",
            Username = "jxm8022",
            Password = "test",
            Wins = 0,
            Ties = 0,
            Losses = 0
        };

        mock.Setup(p => p.GetPlayerbyId(2)).Returns(checkPlayer);
        PlayerController play = new PlayerController(mock.Object, _logger);
        Player result = play.Get(2);
        Assert.Equal(checkPlayer, result);
    }
}