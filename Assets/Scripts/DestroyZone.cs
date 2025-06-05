using UnityEngine;

public class DestroyZone : MonoBehaviour
{
    void OnTriggerEnter(Collider other)
    {
        Debug.Log("인식");
        Destroy(other.gameObject);
    }
}
