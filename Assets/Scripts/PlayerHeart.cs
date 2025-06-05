using UnityEngine;

public class PlayerHeart : MonoBehaviour
{
    public int maxHeart = 3;
    internal int heart;
    public int scoreHeart = 1;

    ScoreManager scoreManager;

    public bool isGameOver;

    void Start()
    {
        heart = maxHeart;
        scoreManager = GameObject.Find("ScoreManager").GetComponent<ScoreManager>();
    }
    void Update()
    {
        if (heart < maxHeart && heart != 0)
        {
            transform.Rotate(0, 0, 30 * Time.deltaTime);
        }
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Enemy") { scoreManager.SetHeart(); }

        if (heart == 0)
        {
            isGameOver = true;
            Destroy(gameObject);
        }
    }
}
