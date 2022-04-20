namespace Model;

public class Board
{
    public int BoardID { get; set; } = -1;
    public int Player1ID { get; set; } = -1;
    public int Player2ID { get; set; } = -1;
    public List<List<int>> BoardState { get; set; } = List<List<int>>();
}