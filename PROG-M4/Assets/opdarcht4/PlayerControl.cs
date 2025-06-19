using UnityEngine;

public class PlayerControl : MonoBehaviour
{
    [SerializeField] private float speed = 5f;
    [SerializeField] private GameObject coinPrefab;

    void Start()
    {
        float randomX = Random.Range(-5f, 0f);
        Vector3 spawnPos = new Vector3(randomX, 0.5f, 0f);
        Instantiate(coinPrefab, spawnPos, Quaternion.identity);
    }

    void Update()
    {
        float move = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.right * move * speed * Time.deltaTime);
    }
}
