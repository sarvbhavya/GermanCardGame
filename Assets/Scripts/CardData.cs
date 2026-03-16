using NUnit.Framework;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class CardFaceInfo
{
    public string FaceColor;
    public int FaceValue;
}

[System.Serializable]
public class Card
{
    public string CardBack;
    public CardFaceInfo CardFace;
}

[CreateAssetMenu(fileName = "CardData", menuName = "Scriptable Objects/CardData")]
public class CardData : ScriptableObject
{
    private List<string> CardFaceColors = new List<string>()
    {
        "Red",
        "Green",
        "Blue",
        "Yellow"
    };

    private List<int> CardFaceValues = new List<int>()
    {
        1, 2, 3, 4, 5, 6, 7, 8, 9, 10
    };

    private List<CardFaceInfo> CardFaces = new List<CardFaceInfo>();

    private List<string> CardBacks = new List<string>()
    {
        "Red",
        "Green",
        "Blue",
        "Yellow"
    };

    public Dictionary<int, Card> Cards = new Dictionary<int, Card>();


    private void OnEnable()
    {
        // List of size 40 containing object CardFaceInfo storing str FaceColor, int FaceValue
        foreach (string color in CardFaceColors)
        {
            foreach (int value in CardFaceValues)
            {
                CardFaceInfo newCard = new CardFaceInfo();

                newCard.FaceColor = color;
                newCard.FaceValue = value;

                CardFaces.Add(newCard);
            }
        }

        int CardID = 0;

        // Dictionary of size 160 containing keys int CardID : values object Card storing str CardBack object CardFaceInfo
        foreach (string back in CardBacks)
        {
            foreach (CardFaceInfo face in CardFaces)
            {
                Card newCard = new Card();
                newCard.CardBack = back;
                newCard.CardFace = face;

                Cards.Add(CardID, newCard);

                CardID++;
            }
        }
    }
}