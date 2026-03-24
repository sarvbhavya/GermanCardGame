using NUnit.Framework;
using System;
using System.Collections.Generic;
using UnityEngine;


public class GameManager : MonoBehaviour
{
    public GameObject PlayerPrefab;
    public GameObject OpponentPrefab;

    public Transform[] OpponentLocations = new Transform[3];
    public Transform[] PlayerLocation = new Transform[1];

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Instantiate(PlayerPrefab, PlayerLocation[0].position, PlayerLocation[0].rotation);

        for (int i = 0; i < OpponentLocations.Length; i++) 
        {
            Instantiate(OpponentPrefab, OpponentLocations[i].position, OpponentLocations[i].rotation);
        }


    }

    // Update is called once per frame
    void Update()
    {

    }
}