using System.Collections.Generic;

public class Player
{
    public List<Card> Hand { get; set; }
    public List<Card> TricksCount { get; set; }
    public int Score { get; set; }
    public string Name { get; set; }
    public int NumberOfTricksChosen { get; set; }
    public Card CardToPlay { get; set; }

    public void ClearHand()
    {
        Hand = new List<Card>();
        TricksCount = new List<Card>();
        CardToPlay = null;
    }
}
