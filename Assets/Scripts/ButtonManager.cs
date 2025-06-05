using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonManager : MonoBehaviour
{
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
        Debug.Log("종료 딸깍");
    }

    public void DeleteScore()
    {

    }
}