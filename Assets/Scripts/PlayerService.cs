using System.Collections.Generic;
using static Smartness;

public class PlayerService
{
    public List<Player> Participants = new List<Player>();

    public PlayerService()
    {
        CreatePlayer(true, "Player1");
        CreatePlayer(false, "West", Difficulty.Easy);
        CreatePlayer(false, "North", Difficulty.Medium);
        CreatePlayer(false, "East", Difficulty.Hard);
    }

    public void CreatePlayer(bool human, string name, Difficulty smartness = Difficulty.Human)
    {
        var newPlayer = new Player();

        if (human == true)
        {
            newPlayer = new HumanPlayer(name);
        }
        else
        {
            newPlayer = new AiPlayer(name, smartness);
        }

        Participants.Add(newPlayer);
    }
}
