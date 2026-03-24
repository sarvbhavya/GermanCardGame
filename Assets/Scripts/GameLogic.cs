using System;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;


[System.Serializable]
public class PlayerDecks
{
    public List<int>[] Players;

    public PlayerDecks(int NumberOfDecks)
    {
        Players = new List<int>[NumberOfDecks];

        for (int i = 0; i < NumberOfDecks; i++)
        {
            Players[i] = new List<int>();
        }
    }
}

public class GameLogic : MonoBehaviour
{
    public CardData myCardData;

    public PlayerDecks Decks;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        int SubdeckCount = myCardData.CardBacks.Count;
        int TotalCards = myCardData.Cards.Keys.Count();
        int DeckSplit = TotalCards / SubdeckCount;

        Decks = new PlayerDecks(SubdeckCount);

        for (int i = 0; i < TotalCards; i++)
        {
            int targetPlayerIndex = i / DeckSplit;

            Decks.Players[targetPlayerIndex].Add(i);
        }



        /* Print cards
        for (int i = 0; i < TotalCards; i++)
        {
            Card Card = myCardData.Cards[i];
            Debug.Log($"Card ID: {i} | Back: {Card.CardBack} | Face: {Card.CardFace.FaceColor} {Card.CardFace.FaceValue}");
        }

        Debug.Log($"Player 0 has {Decks.Players[0].Count} cards. Their first card ID is {Decks.Players[0][0]} and their last is {Decks.Players[0][39]}.");
        Debug.Log($"Player 1 has {Decks.Players[1].Count} cards. Their first card ID is {Decks.Players[1][0]} and their last is {Decks.Players[1][39]}.");
        Debug.Log($"Player 2 has {Decks.Players[2].Count} cards. Their first card ID is {Decks.Players[2][0]} and their last is {Decks.Players[2][39]}.");
        Debug.Log($"Player 3 has {Decks.Players[3].Count} cards. Their first card ID is {Decks.Players[3][0]} and their last is {Decks.Players[3][39]}.");
        */
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
