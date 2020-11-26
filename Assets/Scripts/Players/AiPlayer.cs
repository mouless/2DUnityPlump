using static Smartness;

public class AiPlayer : Player
{
    private Difficulty Difficulty;

    public AiPlayer(string name, Difficulty difficulty)
    {
        Name = name;
        Difficulty = difficulty;
    }
}
