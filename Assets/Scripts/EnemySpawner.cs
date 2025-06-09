using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public Transform[] spawnPosition;
    public GameObject enemyFactory;

    float createTime = 1;
    float minTime = 1f;
    float maxTime = 5f;

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
