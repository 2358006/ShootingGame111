using UnityEngine;

public class Enemy : MonoBehaviour
{
    Vector3 dir;
    GameObject player;
    public float speed = 5;

    public GameObject explosionFactory;

    void Start()
    {
        int rndValue = Random.Range(0, 10);
        player = GameObject.Find("Player");

        if (rndValue <= 3)
        {
            dir = player.transform.position - transform.position;
            dir.Normalize();
        }
        else { dir = Vector3.down; }
    }

    void Update()
    {
        transform.position += dir * speed * Time.deltaTime;
    }

    void OnCollisionEnter(Collision collision)
    {
        GameObject explosion = Instantiate(explosionFactory);
        explosion.transform.position = transform.position;

        Debug.Log($"Enemy taged {collision.gameObject.tag}");

        if (collision.gameObject.tag == "Bullet")
        {
            GameManager.Instance.SetScore();
            Destroy(collision.gameObject);
        }
        Destroy(gameObject);
    }
}
