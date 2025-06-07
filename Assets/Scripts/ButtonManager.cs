using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonManager : MonoBehaviour
{
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.F)) { DeleteScore(); }
    }

    public void OnClickGameStart()
    {
        SceneManager.LoadScene("GameScene");
    }

    public void OnClickRestart()
    {
        SceneManager.LoadScene("GameScene");
    }

    public void OnclickGoTitle()
    {
        SceneManager.LoadScene("GameStart");
    }

    public void OnClickExit()
    {
        Application.Quit();
        Debug.Log("종료함");
    }

    public void DeleteScore()
    {
        PlayerPrefs.DeleteKey("Best Score");
        PlayerPrefs.Save();
    }
}