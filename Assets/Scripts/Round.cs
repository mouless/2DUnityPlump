using System.Collections.Generic;
using Assets.Scripts;
using UnityEngine;

public class Round : MonoBehaviour
{
    public int NumberOfTricks;
    public int WhoGoesFirst;
    public Stack<Card> DeckOfCards;

    public Round(int nrOfTricks, int indexOfWhoStarts)
    {
        NumberOfTricks = nrOfTricks;
        WhoGoesFirst = indexOfWhoStarts;

        var deck = new Deck();

        DeckOfCards = deck.CreateDeck();
        deck.DistributeCards(GameService._playerService.Participants);

    }
}
