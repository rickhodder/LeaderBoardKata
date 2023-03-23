namespace LeaderBoardKata;
public class LeaderBoardService
{
    public LeaderBoard CreateLeaderBoard(IEnumerable<Player> players)
    {
        return new LeaderBoard();
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