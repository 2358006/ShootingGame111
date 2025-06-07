using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public Transform[] spawnPosition;

    float createTime = 1;

    float minTime = 1f;

    float maxTime = 5f;

    public GameObject enemyFactory;

    void Start()
    {
        CreateEnemy();
    }

    void CreateEnemy()
    {
        GameObject enemy = Instantiate(enemyFactory);
        enemy.transform.position = spawnPosition[Random.Range(0, spawnPosition.Length)].position;

        createTime = Random.Range(minTime, maxTime);

        Invoke("CreateEnemy", createTime);
    }
}
