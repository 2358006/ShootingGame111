using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonManager : MonoBehaviour
{
    public void OnClickGameStart()
    {
        SceneManager.LoadScene("GameScene");
    }

    public void OnClickRestart()
    { }

    public void OnclickGoTitle()
    {
        SceneManager.LoadScene("GameStart");
    }

    public void DeleteScore()
    {

    }
}
