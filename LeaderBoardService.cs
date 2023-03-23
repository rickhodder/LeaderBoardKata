namespace LeaderBoardKata;
public class LeaderBoardService
{
    public LeaderBoard CreateLeaderBoard(IEnumerable<Player> players)
    {
        var result= new LeaderBoard();
        result.AddRange(players.OrderByDescending(x => x.Score).Select((x, i) => new LeaderBoardEntry { Rank = i + 1, Name = x.PlayerName, Score = x.Score }).ToList());
        return result;
    }
}

public class Player
{
    public string PlayerName { get; set; }="";
    public int Score { get; set; }
}

public class LeaderBoard : List<LeaderBoardEntry>
{
}

public class LeaderBoardEntry
{
    public int Rank { get; set; }
    public string Name { get; set; }="";

    public int Score { get; set; }
}