using UnityEngine;

public class CoinSpawner : MonoBehaviour
{
    [SerializeField] private GameObject coinPrefab;
    [SerializeField] private float spawnRadius = 10f;

    void Start()
    {
        for (int i = 0; i < 30; i++)
        {
            Vector3 randomPos = new Vector3(
                Random.Range(-spawnRadius, spawnRadius),
                0.5f,
                Random.Range(-spawnRadius, spawnRadius)
            );

            Instantiate(coinPrefab, randomPos, Quaternion.identity);
        }
    }
}
