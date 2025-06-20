using UnityEngine;
using TMPro;
public class GameManager : MonoBehaviour
{
    public float speed = 5f;
    public float timeLeft = 5f;
    private int score = 0;
    public TMPro.TextMeshProUGUI scoreText;
    void Update()
    {
        float moveX = Input.GetAxis("Horizontal");
        float moveZ = Input.GetAxis("Vertical");

        Vector3 move = new Vector3(moveX, 0, moveZ).normalized * speed * Time.deltaTime;
        transform.Translate(move);

        if (timeLeft <= 0)
        {
            Debug.Log("Game Over! Eindscore: " + score);
            enabled = false;
            return;
        }

        timeLeft -= Time.deltaTime;

        Debug.Log("Tijd: " + Mathf.Round(timeLeft) + " | Score: " + score);
    }
    private void FixedUpdate()
    {
        scoreText.text = "Score: " + score;
    }
    

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "Coin")
        {
            score += 10;

            Debug.Log("Munt gepakt! +10 punten");
            Destroy(other.gameObject);
        }
    }
}
