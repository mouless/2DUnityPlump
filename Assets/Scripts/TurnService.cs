using Assets.Scripts;

public class TurnService
{
    private Round _round;
    private int _whoGoesFirst;

    public void CreateNewRound()
    {
        var numberOfRounds = GameService.TricksPerRound.Count;

        if (numberOfRounds > 0)
        {
            _whoGoesFirst = GameService.WhoStartsTheGame;
            _round = new Round(GameService.TricksPerRound.Pop(), _whoGoesFirst);




            WhoGoesFirstNextRound();
            numberOfRounds--;
        }
        else
        {
            // End of Game-methods here!
        }
    }

    private void WhoGoesFirstNextRound()
    {
        _whoGoesFirst++;

        if (_whoGoesFirst >= 4)
        {
            _whoGoesFirst = 0;
        }
    }
}