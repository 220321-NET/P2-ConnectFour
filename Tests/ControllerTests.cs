using Xunit;
using Model;
using Moq;
using Connect4API.Controllers;
using Microsoft.Extensions.Logging;
using System.Collections.Generic;
using DL;

namespace tests;

public class ControllerTests
{
    private readonly ILogger<PlayerController> _PLogger;
    private readonly ILogger<BoardController> _BLogger;
    private readonly ILogger<PieceController> _PCLogger;
    private readonly ILogger<RankingController> _RLogger;
    private readonly ILogger<LobbyController> _LLogger;

    public Mock<IDBRepo> mock = new Mock<IDBRepo>();
    public Mock<IDBRepo> extraMock = new Mock<IDBRepo>();

    /* PlayerController Tests */
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
        PlayerController play = new PlayerController(mock.Object, _PLogger);
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
        PlayerController play = new PlayerController(mock.Object, _PLogger);
        Player result = play.Get(2);
        Assert.Equal(checkPlayer, result);
    }

    [Fact]
    public void GetAllPLayers_PlayersExistsInRep()
    {
        List<Player> checkPlayers = new List<Player> {
            new Player {
                PlayerID = 2,
                Email = "mendozaj9486@gmail.com",
                Username = "jxm8022",
                Password = "test",
                Wins = 0,
                Ties = 0,
                Losses = 0
            },

            new Player {
                PlayerID = 3,
                Email = "baileybarton77@gmail.com",
                Username = "bkwrdbailey",
                Password = "Password123",
                Wins = 0,
                Ties = 0,
                Losses = 0
            },

            new Player {
                PlayerID = 4,
                Email = "gianny281@revature.net",
                Username = "gitfather",
                Password = "1234",
                Wins = 0,
                Ties = 0,
                Losses = 0
            },
        };

        mock.Setup(p => p.GetAllPlayers()).Returns(checkPlayers);
        PlayerController play = new PlayerController(mock.Object, _PLogger);
        List<Player> result = play.GetAll();
        Assert.Equal(checkPlayers, result);
    }

    [Fact]
    public void AddPlayer_PlayerExistsInRep()
    {
        Player checkPlayer = new Player()
        {
            Email = "mapletree@gmail.com",
            Username = "johnnyapple",
            Password = "test",
            Wins = 0,
            Ties = 0,
            Losses = 0
        };

        Player playerToAdd = new Player()
        {
            Email = "mapletree@gmail.com",
            Username = "johnnyapple",
            Password = "test",
            Wins = 0,
            Ties = 0,
            Losses = 0
        };

        mock.Setup(p => p.CreatePlayer(playerToAdd)).Returns(checkPlayer);
        extraMock.Setup(p => p.GetPlayer(playerToAdd.Username)).Returns(checkPlayer);
        PlayerController play = new PlayerController(mock.Object, _PLogger);
        PlayerController extraPlay = new PlayerController(extraMock.Object, _PLogger);
        play.Post(playerToAdd);
        Player result = extraPlay.Get(playerToAdd.Username);
        Assert.Equal(checkPlayer, result);
    }

    [Fact]
    public void UpdateAPlayer_PlayerShouldBeUpdatedInDatabase()
    {
        Player updatePlayer = new Player()
        {
            PlayerID = 3,
            Email = "baileybarton77@gmail.com",
            Username = "bkwrdbailey",
            Password = "Password123",
            Wins = 2,
            Ties = 1,
            Losses = 5
        };

        Player checkPlayer = new Player()
        {
            PlayerID = 3,
            Email = "baileybarton77@gmail.com",
            Username = "bkwrdbailey",
            Password = "Password123",
            Wins = 2,
            Ties = 1,
            Losses = 5
        };

        mock.Setup(p => p.UpdatePlayer(updatePlayer));
        extraMock.Setup(p => p.GetPlayer("bkwrdbailey")).Returns(checkPlayer);
        PlayerController play = new PlayerController(mock.Object, _PLogger);
        PlayerController extraPlay = new PlayerController(extraMock.Object, _PLogger);
        play.Put(updatePlayer);
        Player result = extraPlay.Get("bkwrdbailey");
        Assert.Equal(checkPlayer, result);
    }

    /* BoardController Tests */
    [Fact]
    public void AddABoard_BoardShouldBeInDataBase()
    {
        Board boardCheck = new Board()
        {
            BoardID = 1,
            PlayerID = 3,
            LobbyID = 1
        };

        Board newBoard = new Board()
        {
            BoardID = 1,
            PlayerID = 3,
            LobbyID = 1
        };

        mock.Setup(p => p.CreateBoard(newBoard)).Returns(boardCheck);
        BoardController board = new BoardController(mock.Object, _BLogger);
        Board result = board.Post(newBoard);
        Assert.Equal(boardCheck, result);
    }

    [Fact]
    public void UpdateBoard_BoardShouldUpdateInDatabase()
    {
        Board boardCheck = new Board()
        {
            BoardID = 2,
            PlayerID = 2,
            LobbyID = 2
        };

        Board updateBoard = new Board()
        {
            BoardID = 2,
            PlayerID = 2,
            LobbyID = 2
        };

        mock.Setup(p => p.UpdateBoard(updateBoard));
        extraMock.Setup(p => p.GetBoard(2)).Returns(boardCheck);
        BoardController board = new BoardController(mock.Object, _BLogger);
        BoardController extraBoard = new BoardController(extraMock.Object, _BLogger);
        board.Put(updateBoard);
        Board result = extraBoard.Get(2);
        Assert.Equal(boardCheck, result);
    }

    [Fact]
    public void GetABoard_BoardShouldBeInDatabase()
    {
        Board boardCheck = new Board()
        {
            BoardID = 2,
            PlayerID = 2,
            LobbyID = 2
        };

        Board updateBoard = new Board()
        {
            BoardID = 2,
            PlayerID = 2,
            LobbyID = 2
        };

        mock.Setup(p => p.CreateBoard(updateBoard));
        extraMock.Setup(p => p.GetBoard(2)).Returns(boardCheck);
        BoardController board = new BoardController(mock.Object, _BLogger);
        BoardController extraBoard = new BoardController(extraMock.Object, _BLogger);
        board.Post(updateBoard);
        Board result = extraBoard.Get(2);
        Assert.Equal(boardCheck, result);
    }

    /* PieceController Tests */
    [Fact]
    public void AddAPiece_PieceShouldBeInDatabase()
    {
        Piece newPiece = new Piece()
        {
            PieceID = 1,
            BoardID = 1,
            PlayerID = 2,
            xCoordinate = 5,
            yCoordinate = 3
        };

        Piece checkPiece = new Piece()
        {
            PieceID = 1,
            BoardID = 1,
            PlayerID = 2,
            xCoordinate = 5,
            yCoordinate = 3
        };

        mock.Setup(p => p.CreatePiece(newPiece)).Returns(checkPiece);
        extraMock.Setup(p => p.GetPiece(1)).Returns(checkPiece);
        PieceController piece = new PieceController(mock.Object, _PCLogger);
        PieceController extraPiece = new PieceController(extraMock.Object, _PCLogger);
        piece.Post(newPiece);
        Piece result = extraPiece.Get(1);
        Assert.Equal(checkPiece, result);
    }

    [Fact]
    public void GetAllPieces_PiecesShouldBeInDatabase()
    {
        List<Piece> pieces = new List<Piece>
        {
            new Piece {
                PieceID = 1,
                BoardID = 2,
                PlayerID = 2,
                xCoordinate = 3,
                yCoordinate = 4
            },

            new Piece {
                PieceID = 1,
                BoardID = 2,
                PlayerID = 2,
                xCoordinate = 4,
                yCoordinate = 5
            },

            new Piece {
                PieceID = 1,
                BoardID = 2,
                PlayerID = 2,
                xCoordinate = 5,
                yCoordinate = 5
            }
        };

        mock.Setup(p => p.GetAllPieces(2)).Returns(pieces);
        PieceController piece = new PieceController(mock.Object, _PCLogger);
        List<Piece> result = piece.GetAll(2);
        Assert.Equal(pieces, result);
    }

    [Fact]
    public void GetAPiece_PieceShouldBeInDatabase()
    {
        Piece pieceCheck = new Piece
        {
            PieceID = 5,
            BoardID = 2,
            PlayerID = 2,
            xCoordinate = 2,
            yCoordinate = 3
        };

        mock.Setup(p => p.GetPiece(5)).Returns(pieceCheck);
        PieceController piece = new PieceController(mock.Object, _PCLogger);
        Piece result = piece.Get(5);
        Assert.Equal(pieceCheck, result);
    }

    /* RankingController Tests */
    [Fact]
    public void GetPlayersRank_RankShouldBeInDatabase()
    {
        mock.Setup(p => p.GetPlayerRank(2)).Returns(10);
        RankingController ranking = new RankingController(mock.Object, _RLogger);
        int result = ranking.Get(2);
        Assert.Equal(10, result);
    }

    [Fact]
    public void GetAllPlayerRanks_RanksShouldBeInDatabase()
    {
        List<Ranking> ranksCheck = new List<Ranking>
        {
            new Ranking {
                RankingID = 2,
                PlayerID = 2,
                Rank = 7
            },

            new Ranking {
                RankingID = 3,
                PlayerID = 3,
                Rank = 9
            },

            new Ranking {
                RankingID = 1,
                PlayerID = 1,
                Rank = 4
            }
        };

        mock.Setup(p => p.GetAllPlayerRanks()).Returns(ranksCheck);
        RankingController ranking = new RankingController(mock.Object, _RLogger);
        List<Ranking> result = ranking.GetAll();
        Assert.Equal(ranksCheck, result);
    }

    [Fact]
    public void UpdatePlayerRanking_RankShouldBeUpdatedInDatabase()
    {
        Ranking updateRank = new Ranking
        {
            RankingID = 2,
            PlayerID = 1,
            Rank = 10
        };

        mock.Setup(p => p.UpdateRank(updateRank));
        extraMock.Setup(p => p.GetPlayerRank(1)).Returns(10);
        RankingController ranking = new RankingController(mock.Object, _RLogger);
        RankingController extraRanking = new RankingController(extraMock.Object, _RLogger);
        ranking.Put(updateRank);
        int result = extraRanking.Get(1);
        Assert.Equal(10, result);
    }

    /* LobbyController Tests */
    [Fact]
    public void AddALobby_LobbyShouldBeInDatabase()
    {
        Lobby newLobby = new Lobby
        {
            LobbyID = 1,
            Player1ID = 1,
            Player2ID = 2
        };

        Lobby lobbyCheck = new Lobby
        {
            LobbyID = 1,
            Player1ID = 1,
            Player2ID = 2
        };

        mock.Setup(p => p.CreateLobby(newLobby)).Returns(lobbyCheck);
        LobbyController lobby = new LobbyController(mock.Object, _LLogger);
        Lobby result = lobby.Post(newLobby);
        Assert.Equal(lobbyCheck, result);
    }
}