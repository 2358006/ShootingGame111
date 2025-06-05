using UnityEngine;

public class PlayerHeart : MonoBehaviour
{
    public int maxHeart = 3;
    public int scoreHeart = 1;
    internal int heart;

    public bool isGameOver;

    void Start()
    {
        heart = maxHeart;
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
        Debug.Log($"Player taged {collision.gameObject.tag}");
        GameManager.Instance.SetHeart(collision.gameObject.tag);

        if (heart == 0)
        {
            Destroy(gameObject);
        }
    }
}
