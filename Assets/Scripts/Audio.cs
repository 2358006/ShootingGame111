using UnityEngine;

public class Audio : MonoBehaviour
{
    public AudioClip bgmClip;
    AudioSource audioSource;

    void Awake()
    {
        audioSource = GetComponent<AudioSource>();
        DontDestroyOnLoad(gameObject);
        audioSource.Play();
    }
}
