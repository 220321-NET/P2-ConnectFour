using Xunit;
using Model;
using System;

namespace tests;

public class ModelTests
{

    /* Ranking Model Tests */
    [Fact]
    public void RankingRankShouldBeInt()
    {
        int newRank = 50;
        Ranking rank = new Ranking();

        rank.Rank = newRank;

        Assert.Equal(50, rank.Rank);
    }

    [Fact]
    public void RankingIdShouldBeInt()
    {
        int rankId = 1;
        Ranking rank = new Ranking();

        rank.RankingID = rankId;

        Assert.Equal(1, rank.RankingID);
    }

    [Fact]
    public void RankingPlayerIdShouldBeInt()
    {
        int userId = 3;
        Ranking rank = new Ranking();

        rank.PlayerID = userId;

        Assert.Equal(3, rank.PlayerID);
    }

    /* Player Model Tests */
    [Fact]
    public void PlayerIdShouldBeInt()
    {
        int userId = 1;
        Player user = new Player();

        user.PlayerID = userId;

        Assert.Equal(1, user.PlayerID);
    }

    [Fact]
    public void PlayerEmailShouldBeString()
    {
        string email = "baileyboop@yahoo.com";
        Player user = new Player();

        user.Email = email;

        Assert.Equal("baileyboop@yahoo.com", user.Email);
    }

    [Fact]
    public void PlayerUsernameShouldBeString()
    {
        string username = "canaryFairy";
        Player user = new Player();

        user.Username = username;

        Assert.Equal("canaryFairy", user.Username);
    }

    [Fact]
    public void PlayerPasswordShouldBeString()
    {
        string password = "test123";
        Player user = new Player();

        user.Password = password;

        Assert.Equal("test123", user.Password);
    }

    [Fact]
    public void PlayerWinsShouldBeInt()
    {
        int newWins = 5;
        Player user = new Player();

        user.Wins = newWins;

        Assert.Equal(5, user.Wins);
    }

    [Fact]
    public void PlayerLossesShouldBeInt()
    {
        int newLosses = 10;
        Player user = new Player();

        user.Losses = newLosses;

        Assert.Equal(10, user.Losses);
    }

    [Fact]
    public void PlayerTiesShouldBeInt()
    {
        int newDraws = 3;
        Player user = new Player();

        user.Ties = newDraws;

        Assert.Equal(3, user.Ties);
    }

    /* Piece Model Tests */
    [Fact]
    public void PieceIdShouldBeInt()
    {
        int pieceId = 1;
        Piece piece = new Piece();

        piece.PieceID = pieceId;

        Assert.Equal(1, piece.PieceID);
    }

    [Fact]
    public void PieceBoardIdShouldBeInt()
    {
        int boardId = 2;
        Piece piece = new Piece();

        piece.BoardID = boardId;

        Assert.Equal(2, piece.BoardID);
    }

    [Fact]
    public void PiecePlayerIdShouldBeInt()
    {
        int playerId = 3;
        Piece piece = new Piece();

        piece.PlayerID = playerId;

        Assert.Equal(3, piece.PlayerID);
    }

    [Fact]
    public void PieceXCoordinateShouldBeInt()
    {
        int newXcoord = 10;
        Piece piece = new Piece();

        piece.xCoordinate = newXcoord;

        Assert.Equal(10, piece.xCoordinate);
    }

    [Fact]
    public void PieceYCoordinateShouldBeInt()
    {
        int newYcoord = 9;
        Piece piece = new Piece();

        piece.yCoordinate = newYcoord;

        Assert.Equal(9, piece.yCoordinate);
    }

    /* Lobby Model Tests */
    [Fact]
    public void LobbyIdShouldBeInt()
    {
        int lobbyId = 2;
        Lobby lobby = new Lobby();

        lobby.LobbyID = lobbyId;

        Assert.Equal(2, lobby.LobbyID);
    }

    [Fact]
    public void LobbyPlayer1IdShouldBeInt()
    {
        int playerId = 1;
        Lobby lobby = new Lobby();

        lobby.Player1ID = playerId;

        Assert.Equal(1, lobby.Player1ID);
    }

    [Fact]
    public void LobbyPlayer2IdShouldBeInt()
    {
        int playerId = 2;
        Lobby lobby = new Lobby();

        lobby.Player2ID = playerId;

        Assert.Equal(2, lobby.Player2ID);
    }

    /* Board Model Tests */
    [Fact]
    public void BoardIdShouldBeInt()
    {
        int boardId = 1;
        Board board = new Board();

        board.BoardID = boardId;

        Assert.Equal(1, board.BoardID);
    }

    [Fact]
    public void BoardPlayerIdShouldBeInt()
    {
        int playerId = 3;
        Board board = new Board();

        board.PlayerID = playerId;

        Assert.Equal(3, board.PlayerID);
    }

    [Fact]
    public void BoardLobbyIdShouldBeInt()
    {
        int lobbyId = 2;
        Board board = new Board();

        board.LobbyID = lobbyId;

        Assert.Equal(2, board.LobbyID);
    }
}