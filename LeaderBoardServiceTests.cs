namespace LeaderBoardKata;

public class LeaderBoardServiceTests
{
    private LeaderBoardService _sut;

    public LeaderBoardServiceTests()
    {
        _sut = new LeaderBoardService();
    }

    [Fact]
    public void CreateLeaderBoard_Exists()
    {
        var leaderBoard = _sut.CreateLeaderBoard(new List<Player>());
        Assert.NotNull(leaderBoard);
    }

    [Fact]
    public void CreateLeaderBoard_()
    {
        var players = new List<Player> {
            new Player { PlayerName = "Bill", Score = 7 },
            new Player { PlayerName = "Chris", Score = 8 },
            new Player { PlayerName = "Dan", Score = 10 },
        };
        
        var leaderBoard = _sut.CreateLeaderBoard(players);

        Assert.True(leaderBoard[0].Name=="Dan");
        Assert.True(leaderBoard[1].Name=="Chris");
        Assert.True(leaderBoard[2].Name=="Bill");
    }
}