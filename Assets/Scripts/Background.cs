using UnityEngine;

public class Background : MonoBehaviour
{
    public Material bgMaterail;

    public float scrollSpeed = 0.2f;

    void Update()
    {
        Vector2 direction = Vector2.up;

        bgMaterail.mainTextureOffset += direction * scrollSpeed * Time.deltaTime;
    }
}
