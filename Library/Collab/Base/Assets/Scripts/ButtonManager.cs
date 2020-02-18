using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class ButtonManager : MonoBehaviour {

    public void NewGameBtn(string NewGameLevel)
    {
        AudioManager.getInstance().Play("Theme");
        Time.timeScale = 1;
        SceneManager.LoadScene(NewGameLevel);
    }
    
    public void ExitGameBtn()
    {
        Application.Quit();
    }

    public void ShopBtn(string NewGameLevel)
    {
        SceneManager.LoadScene(NewGameLevel);
    }
}
