using UnityEngine;
using TMPro;
public class GameManager1 : MonoBehaviour
{
    public float speed1 = 5f;
    public float timeLeft1 = 5f;
    private int score1 = 0;
    public TMPro.TextMeshProUGUI scoreText1;
    void Update()
    {
        float moveX = Input.GetAxis("Horizontal");
        float moveZ = Input.GetAxis("Vertical");

        Vector3 move = new Vector3(moveX, 0, moveZ).normalized * speed1 * Time.deltaTime;
        transform.Translate(move);

        if (timeLeft1 <= 0)
        {
            Debug.Log("Game Over! Eindscore: " + score1);
            enabled = false;
            return;
        }

        timeLeft1 -= Time.deltaTime;

        Debug.Log("Tijd: " + Mathf.Round(timeLeft1) + " | Score: " + score1);
    }
    private void FixedUpdate()
    {
        scoreText1.text = "Score: " + score1;
    }
    

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "Coin")
        {
            score1 += 10;

            Debug.Log("Munt gepakt! +10 punten");
            Destroy(other.gameObject);
        }
    }
}
