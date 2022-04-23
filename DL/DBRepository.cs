using Model;
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
    public void UpdateRank(Board board)
    {

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
    public Piece CreatePiece(Piece piece)
    {
        _context.Pieces.Add(piece);
        _context.SaveChanges();

        return piece;
    }

    //_/~\_/~\_/~\_/~\_/~\_/~\_/~\_/~\_/~\_/~\_/~\_/~\_/~\_/~\_





    //_/~\_/~\_/~\_/~\_/~\_/~\_/~\_/~\_/~\_/~\_/~\_/~\_/~\_/~\_
    //          Family Member:  Donte
    //_/~\_/~\_/~\_/~\_/~\_/~\_/~\_/~\_/~\_/~\_/~\_/~\_/~\_/~\_

    //Board
    public Board GetBoard()
    {
        return new Board();
    }

    //Create a lobby
    public int CreateLobby()
    {
        return -1;
    }

    //_/~\_/~\_/~\_/~\_/~\_/~\_/~\_/~\_/~\_/~\_/~\_/~\_/~\_/~\_
}
