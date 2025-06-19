using UnityEngine;

public class ScoreManager : MonoBehaviour
{
    private int score = 0;

    public void AddScore(int points)
    {
        score += points;
        Debug.Log("Munt gepakt! Score: " + score);
    }
}
