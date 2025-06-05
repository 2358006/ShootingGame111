using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance { get; private set; } // 싱글톤
    public Text currentScoreUI;
    int currentScore;

    public Text bestScoreUI;
    int bestScore;

    public Text lifeUI;
    PlayerHeart life;


    void Awake()
    {
        // 싱글톤
        if (Instance == null) { Instance = this; }
        else { Destroy(gameObject); }

        bestScore = PlayerPrefs.GetInt("Best Score", 0);
        life = GameObject.Find("Player").GetComponent<PlayerHeart>();
    }
    void Start()
    {

        lifeUI.text = $"Life : {life.heart}";

        bestScoreUI.text = $"Best Score : {bestScore}";
        Debug.Log($"Best Score : {bestScore}");
        currentScoreUI.text = $"Current Score : {currentScore}";
    }

    public void SetScore()
    {
        currentScore++;

        currentScoreUI.text = $"Current Score : {currentScore}";

        if (currentScore > bestScore)
        {
            bestScore = currentScore;
            bestScoreUI.text = $"Best Score : {bestScore}";
            PlayerPrefs.SetInt("Best Score", bestScore);
            PlayerPrefs.Save();
        }
    }


    public void SetHeart(string tag)
    {
        if (tag == "Enemy") { life.heart -= life.scoreHeart; }
        if (tag == "Item")
        {
            if (life.heart < life.maxHeart) { life.heart += life.scoreHeart; }
        }

        lifeUI.text = $"Life : {life.heart}";
    }

    public void GameOver()
    {
        SceneManager.LoadScene("GameOver");
    }
}
