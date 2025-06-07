using UnityEngine;
using UnityEngine.InputSystem.Controls;

public class PlayerHeart : MonoBehaviour
{
    public int maxHeart = 3;
    public int scoreHeart = 1;
    internal int heart;
    float delta = 1f;
    void Start()
    {
        heart = maxHeart;
    }
    void Update()
    {
        HeartTest();
        // 최대 아닐때는 비행기 회전
        if (heart < maxHeart && heart != 0)
        {
            if (heart == 1) { delta = 1.5f; }
            transform.Rotate(0, 0, 30 * delta * Time.deltaTime);
        }

        // 생명이 최대 일때 로테이션 고정
        if (heart == maxHeart)
        {
            transform.rotation = new Quaternion(0f, 0f, 0f, 0f);
        }
    }

    void OnCollisionEnter(Collision collision)
    {
        Debug.Log($"Player taged {collision.gameObject.tag}");

        GameManager.Instance.SetHeart(collision.gameObject.tag);

        if (heart == 0)
        {
            GameManager.Instance.GameOver();
        }
    }

    void HeartTest()
    {
        if (Input.GetKeyDown(KeyCode.R)) { GameManager.Instance.SetHeart("Enemy"); }
        if (Input.GetKeyDown(KeyCode.T)) { GameManager.Instance.SetHeart("Item"); }
    }
}
