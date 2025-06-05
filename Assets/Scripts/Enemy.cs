using UnityEngine;

public class Enemy : MonoBehaviour
{
    Vector3 dir;
    GameObject player;
    public float speed = 5;

    public GameObject explosionFactory;

    ScoreManager scoreManager;

    void Start()
    {
        scoreManager = GameObject.Find("ScoreManager").GetComponent<ScoreManager>();

        int rndValue = Random.Range(0, 10);
        player = GameObject.Find("Player");

        if (rndValue <= 3)
        {
            dir = player.transform.position - transform.position;
            dir.Normalize();
        }
        else
        {
            dir = Vector3.down;
            //transform.position += dir * speed * Time.deltaTime;
        }
    }

    void Update()
    {
        transform.position += dir * speed * Time.deltaTime;
    }

    void OnCollisionEnter(Collision collision)
    {
        GameObject explosion = Instantiate(explosionFactory);
        explosion.transform.position = transform.position;

        Debug.Log($"{collision.gameObject.tag}에 맞았어요");

        if (collision.gameObject.tag == "Bullet")
        {
            scoreManager.SetScore();
            Destroy(collision.gameObject);
            Destroy(gameObject);
        }

        if (collision.gameObject.tag == "Player")
        {
            Destroy(gameObject);
        }
    }
}
