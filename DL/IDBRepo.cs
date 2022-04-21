using Model;

namespace DL;

public interface IDBRepo
{
    //Leaderbords
    public List<Player> GetAllPlayers();



    //Handles signup
    public Player CreatePlayer(Player playerToCreate);


    //Searching player profile before game 
    public Player GetPlayer(string username);



    //Piece information
    public Piece GetPiece();
    public Piece CreatePiece();



    //Board
    public Board GetBoard();



    //Ranking system
    public void UpdateRank(Board board);



    //Create a lobby
    public int CreateLobby();
}