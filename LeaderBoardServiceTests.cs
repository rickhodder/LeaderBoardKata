namespace LeaderBoardKata;

public class LeaderBoardServiceTests
{

    [Fact]
    public void CreateLeaderBoard_Exists()
    {
        // Arrange
        var leaderBoardService = new LeaderBoardService();

        // Act
        var leaderBoard = leaderBoardService.CreateLeaderBoard(new List<Player>());

        // Assert
        Assert.NotNull(leaderBoard);
    }
}