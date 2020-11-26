public class Card
{
    public enum CardSuit { Hj�rter = 1, Spader, Ruter, Kl�ver }
    public enum CardRank { Tv� = 2, Tre, Fyra, Fem, Sexa, Sju, �tta, Nio, Tio, Knekt, Dam, Knug, Ess }

    public CardSuit Suit { get; set; }
    public CardRank Rank { get; set; }
    public string Symbol { get; set; }

    public Card(CardSuit suit, CardRank rank)
    {
        Suit = suit;
        Rank = rank;
    }

    public override string ToString()
    {
        return Suit.ToString() + " - " + Rank.ToString();
    }
}