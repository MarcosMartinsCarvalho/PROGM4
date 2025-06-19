using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    [SerializeField] private float speed = 5f;
    [SerializeField] private ScoreManager scoreManager;

    void Start()
    {
        if (scoreManager == null)
        {
            Debug.LogError("ScoreManager ontbreekt!");
        }
    }

    void Update()
    {
        float move = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.right * move * speed * Time.deltaTime);
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "Coin")
        {
            scoreManager.AddScore(10);
            Debug.Log("Munt gepakt!");
            Destroy(other.gameObject);
        }
    }
}
