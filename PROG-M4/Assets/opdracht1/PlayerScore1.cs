using UnityEngine;
using System.Collections.Generic;

public class PlayerScore1 : MonoBehaviour
{
    private int score = 0;
    private List<int> coins = new List<int>();

    void Start()
    {
        for (int i = 0; i < 3; i++)
        {
            Debug.Log("Spel begint!");
        }
    }

    void Update()
    {
        if (score >= 50)
        {
            Debug.Log("Je hebt gewonnen!");
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            AddCoin(10);
        }
    }

    void AddCoin(int coinValue)
    {
        coins.Add(coinValue);
        score += coinValue;
        Debug.Log("Munt gepakt! Score: " + score);
    }
}
