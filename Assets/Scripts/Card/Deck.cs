using System.Collections.Generic;
using System.Linq;
using Assets.Scripts;

class Deck
{
    public Stack<Card> CreateDeck()
    {
        var deckOfCards = new List<Card>();
        for (Card.CardSuit i = Card.CardSuit.Hjärter; i <= Card.CardSuit.Klöver; i++)
        {
            for (Card.CardRank j = Card.CardRank.Två; j <= Card.CardRank.Ess; j++)
            {
                deckOfCards.Add(new Card(i, j));
            }
        }

        var result = ShuffleDeck(deckOfCards);

        return result;
    }

    private Stack<Card> ShuffleDeck(List<Card> deck)
    {
        for (int n = deck.Count - 1; n > 0; --n)
        {
            int k = GameService.r.Next(n + 1);
            var temp = deck[n];
            deck[n] = deck[k];
            deck[k] = temp;
        }

        var result = new Stack<Card>(deck);

        return result;
    }

    public void DistributeCards(List<Player> players, Stack<Card> deckOfCards, int numberOfSticksThisRound)
    {
        // Deal cards to each player
        for (int i = 0; i < numberOfSticksThisRound; i++)
        {
            foreach (var player in players)
            {
                player.Hand.Add(deckOfCards.Pop());
            }
        }

        // Order their cards by Suit than Rank
        foreach (var player in players)
        {
            var newHand = player.Hand.OrderBy(c => c.Suit).ThenByDescending(c => c.Rank).ToList();
            player.ClearHand();

            foreach (var card in newHand)
            {
                player.Hand.Add(card);
            }
        }
    }
}