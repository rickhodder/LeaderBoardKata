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
