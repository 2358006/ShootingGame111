using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    public Text currentScoreUI;
    int currentScore;

    public Text bestScoreUI;
    int bestScore;

    public Text lifeUI;
    PlayerHeart life;

    void Start()
    {
        life = GameObject.Find("Player").GetComponent<PlayerHeart>();
        lifeUI.text = $"Life : {life.heart}";

        bestScore = PlayerPrefs.GetInt("Best Score", 0);
        bestScoreUI.text = $"Best Score : {bestScore}";

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
        }
    }


    public void SetHeart()
    {
        life.heart -= life.scoreHeart;
        lifeUI.text = $"Life : {life.heart}";
    }
}
