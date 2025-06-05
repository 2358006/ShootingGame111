using UnityEngine;

public class Enemy : MonoBehaviour
{
    public float speed = 5;
    AudioSource audioSource;
    public AudioClip explosionClip;

    Vector3 dir;
    GameObject player;

    public GameObject explosionFactory;

    void Awake()
    {
        audioSource = GetComponent<AudioSource>();
    }

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
        Debug.Log($"Enemy taged {collision.gameObject.tag}");

        if (collision.gameObject.tag != "Item")
        {
            GameObject explosion = Instantiate(explosionFactory);
            explosion.transform.position = transform.position;

            if (collision.gameObject.tag == "Bullet")
            {
                GameManager.Instance.SetScore();

                audioSource.PlayOneShot(explosionClip);
                Destroy(collision.gameObject);
            }

            Destroy(gameObject);
        }
    }
}
