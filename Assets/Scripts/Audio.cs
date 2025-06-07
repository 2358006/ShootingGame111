using UnityEngine;

public class Audio : MonoBehaviour
{
    public static Audio Instance { get; private set; } // 싱글톤 

    AudioSource audioSource;

    void Awake()
    {
        // 싱글톤 
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }
    void Start()
    {
        // 재생
        audioSource = GetComponent<AudioSource>();
        audioSource.Play();
    }
}
