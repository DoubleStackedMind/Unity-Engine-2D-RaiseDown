using UnityEngine.SceneManagement;
using UnityEngine;
using UnityEngine.UI;

public class ButtonManager : MonoBehaviour
{
   

    public void NewGameBtn(string NewGameLevel)
    {
        AudioManager.getInstance().Play("Theme");
        Time.timeScale = 1;
        SceneManager.LoadScene(NewGameLevel);
    }

    public void ReturnToMainMenuBtn()
    {
        SceneManager.LoadScene("MainMenu");
    }
    public void ExitGameBtn()
    {
        Application.Quit();
    }

    public void ShopBtn(string NewGameLevel)
    {
        SceneManager.LoadScene(NewGameLevel);
    }

    public void muteMusic()
    {
        AudioManager.getInstance().mute();
        Config.getInstance().changeSprite();
    }
}