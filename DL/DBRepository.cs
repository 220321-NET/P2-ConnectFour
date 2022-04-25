using Model;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace DL;


public class DBRepository : IDBRepo
{
    private readonly C4DBContext _context;

    public DBRepository(C4DBContext context)
    {
        _context = context;
    }

    //_/~\_/~\_/~\_/~\_/~\_/~\_/~\_/~\_/~\_/~\_/~\_/~\_/~\_/~\_
    //          Family Member: Bailey
    //_/~\_/~\_/~\_/~\_/~\_/~\_/~\_/~\_/~\_/~\_/~\_/~\_/~\_/~\_

    //Ranking system
    public void UpdateRank(Ranking rankToUpdate)
    {
        _context.Rankings.Update(rankToUpdate);
        _context.SaveChanges();
        _context.ChangeTracker.Clear();
    }

    public List<Ranking> GetAllPlayerRanks() {
        return _context.Rankings.AsNoTracking().ToList();
    }

    public int GetPlayerRank(Player playerRank) {
        return _context.Rankings.AsNoTracking().FirstOrDefault(rank => rank.PlayerID == playerRank.PlayerID).Rank;
    }

    //_/~\_/~\_/~\_/~\_/~\_/~\_/~\_/~\_/~\_/~\_/~\_/~\_/~\_/~\_





    //_/~\_/~\_/~\_/~\_/~\_/~\_/~\_/~\_/~\_/~\_/~\_/~\_/~\_/~\_
    //          Family Member: Gianny
    //_/~\_/~\_/~\_/~\_/~\_/~\_/~\_/~\_/~\_/~\_/~\_/~\_/~\_/~\_
  
   //Searching player profile before game 
    public Player GetPlayer(string username)
    {
        return _context.Players.FirstOrDefault(player => player.Username == username);
    }

    //Leaderboards
    public List<Player> GetAllPlayers(int playerID)
    {
        return _context.Players.ToList();
    }

    //Handles signup
    public Player CreatePlayer(Player playerToCreate)
    {
        _context.Players.Add(playerToCreate);
        _context.SaveChanges();
        return playerToCreate;
    }

    //_/~\_/~\_/~\_/~\_/~\_/~\_/~\_/~\_/~\_/~\_/~\_/~\_/~\_/~\_





    //_/~\_/~\_/~\_/~\_/~\_/~\_/~\_/~\_/~\_/~\_/~\_/~\_/~\_/~\_
    //          Family Member:  Jose
    //_/~\_/~\_/~\_/~\_/~\_/~\_/~\_/~\_/~\_/~\_/~\_/~\_/~\_/~\_

    //Piece information
    public Piece GetPiece(int pieceID)
    {
        return _context.Pieces.FirstOrDefault(piece => piece.PieceID == pieceID);
    }

    public List<Piece> GetAllPieces(int boardID)
    {
        return _context.Pieces.ToList();
    }
    public Piece CreatePiece(Piece pieceToCreate)
    {
        _context.Pieces.Add(pieceToCreate);
        _context.SaveChanges();

        return pieceToCreate;
    }
    
    //_/~\_/~\_/~\_/~\_/~\_/~\_/~\_/~\_/~\_/~\_/~\_/~\_/~\_/~\_





    //_/~\_/~\_/~\_/~\_/~\_/~\_/~\_/~\_/~\_/~\_/~\_/~\_/~\_/~\_
    //          Family Member:  Donte
    //_/~\_/~\_/~\_/~\_/~\_/~\_/~\_/~\_/~\_/~\_/~\_/~\_/~\_/~\_

    //Board
    public Board GetBoard(int lobbyId)
    {
        return new Board();
    }

    public Board CreateBoard(Board boardToCreate)
    {
        _context.Boards.Add(boardToCreate);
        _context.SaveChanges();
        return boardToCreate;
    }

    //Create a lobby
    public Lobby CreateLobby(Lobby lobbyToCreate)
    {
        _context.Lobbys.Add(lobbyToCreate);
        _context.SaveChanges();
        return lobbyToCreate;
    }

    //_/~\_/~\_/~\_/~\_/~\_/~\_/~\_/~\_/~\_/~\_/~\_/~\_/~\_/~\_
}
