using System.ComponentModel.DataAnnotations;
namespace Model;

public class Ranking
{
    [Key]
    public int RankingID{get;set;}

    public int PlayerID{get;set;}

    public int Rank{get;set;}

}