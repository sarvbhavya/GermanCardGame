using UnityEngine;

public class GameLogic : MonoBehaviour
{
    public CardData CardData;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        if (CardData != null)
        {
            
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
