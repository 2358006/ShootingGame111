using UnityEngine;

public class EnemyManager : MonoBehaviour
{
    public Transform[] spawnPosition;
    float currentTime;

    public float createTime = 1;

    float minTime = 1;

    float maxTime = 5;

    public GameObject enemyFactory;

    void Start()
    {
        createTime = Random.Range(minTime, maxTime);
        CreateEnemy();
    }

    void Update()
    {
        // currentTime += Time.deltaTime;

        // if (currentTime > createTime)
        // {
        //     GameObject enemy = Instantiate(enemyFactory);
        //     enemy.transform.position = spawnPosition[Random.Range(0, spawnPosition.Length)].position;

        //     currentTime = 0;
        //     createTime = Random.Range(minTime, maxTime);
        // }
    }

    void CreateEnemy()
    {
currentTime += Time.deltaTime;

        if (currentTime > createTime)
        {
            GameObject enemy = Instantiate(enemyFactory);
            enemy.transform.position = spawnPosition[Random.Range(0, spawnPosition.Length)].position;

            currentTime = 0;
            createTime = Random.Range(minTime, maxTime);
        }
Invoke("CreateEnemy", createTime);
    }
}
