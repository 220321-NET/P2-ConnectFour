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

    //Leaderboards
    public List<Player> GetAllPlayers()
    {
        return new List<Player>();
    }

    //Handles signup
    public Player CreatePlayer(Player playerToCreate)
    {
        return new Player();
    }

    //Searching player profile before game 
    public Player GetPlayer(string username)
    {
        return new Player();
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
