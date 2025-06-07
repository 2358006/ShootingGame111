using UnityEngine;

public class ItemSpawner : MonoBehaviour
{
    public Transform[] spawnPosition;

    float createTime = 1;

    float minTime = 1f;

    float maxTime = 5f;

    public GameObject itemFactory;

    void Start()
    {
        CreateItem();
    }

    void CreateItem()
    {
        GameObject item = Instantiate(itemFactory);
        item.transform.position = spawnPosition[Random.Range(0, spawnPosition.Length)].position;

        createTime = Random.Range(minTime, maxTime);

        Invoke("CreateItem", createTime);
    }
}
