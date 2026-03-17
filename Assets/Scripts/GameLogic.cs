using System;
using UnityEngine;

public class GameLogic : MonoBehaviour
{
    public CardData myCardData;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        if (myCardData != null)
        {
            int SubdeckCount = myCardData.CardBacks.Count;

            // Distribute Deck into 4 based on # of unique backs
            for (int i = 0; i < 16???; i++)
            {
                Card Card = myCardData.Cards[i];
                // Debug.Log($"Card ID: {i} | Back: {Card.CardBack} | Face: {Card.CardFace.FaceColor} {Card.CardFace.FaceValue}");


            }
        }
        else
        {
            Debug.LogWarning("No CardData found!");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
