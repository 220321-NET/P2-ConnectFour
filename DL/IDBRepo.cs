using Model;

namespace DL;

public interface IDBRepo
{


    //_/~\_/~\_/~\_/~\_/~\_/~\_/~\_/~\_/~\_/~\_/~\_/~\_/~\_/~\_
    //          Family Member: Bailey
    //_/~\_/~\_/~\_/~\_/~\_/~\_/~\_/~\_/~\_/~\_/~\_/~\_/~\_/~\_

    //Ranking system
    public void UpdateRank(Ranking rankToUpdate);

    public List<Ranking> GetAllPlayerRanks();
    
    public int GetPlayerRank(Player playerRank);

    //_/~\_/~\_/~\_/~\_/~\_/~\_/~\_/~\_/~\_/~\_/~\_/~\_/~\_/~\_





    //_/~\_/~\_/~\_/~\_/~\_/~\_/~\_/~\_/~\_/~\_/~\_/~\_/~\_/~\_
    //          Family Member: Gianny
    //_/~\_/~\_/~\_/~\_/~\_/~\_/~\_/~\_/~\_/~\_/~\_/~\_/~\_/~\_

    //Searching player profile before game 
    public Player GetPlayer(string username);

    //Leaderboards
    public List<Player> GetAllPlayers(int playerID);

    //Handles signup
    public Player CreatePlayer(Player playerToCreate);
 
    //_/~\_/~\_/~\_/~\_/~\_/~\_/~\_/~\_/~\_/~\_/~\_/~\_/~\_/~\_





    //_/~\_/~\_/~\_/~\_/~\_/~\_/~\_/~\_/~\_/~\_/~\_/~\_/~\_/~\_
    //          Family Member:  Jose
    //_/~\_/~\_/~\_/~\_/~\_/~\_/~\_/~\_/~\_/~\_/~\_/~\_/~\_/~\_

    //Piece information
    public Piece GetPiece(int pieceID);
    public List<Piece> GetAllPieces(int boardID);
    public Piece CreatePiece(Piece piece);

    //_/~\_/~\_/~\_/~\_/~\_/~\_/~\_/~\_/~\_/~\_/~\_/~\_/~\_/~\_





    //_/~\_/~\_/~\_/~\_/~\_/~\_/~\_/~\_/~\_/~\_/~\_/~\_/~\_/~\_
    //          Family Member:  Donte
    //_/~\_/~\_/~\_/~\_/~\_/~\_/~\_/~\_/~\_/~\_/~\_/~\_/~\_/~\_

    //Board
    public Board GetBoard(int lobbyId);

    public Board CreateBoard(Board board);

    //Create a lobby
    public Lobby CreateLobby(Lobby lobbyToCreate);

    //_/~\_/~\_/~\_/~\_/~\_/~\_/~\_/~\_/~\_/~\_/~\_/~\_/~\_/~\_

}