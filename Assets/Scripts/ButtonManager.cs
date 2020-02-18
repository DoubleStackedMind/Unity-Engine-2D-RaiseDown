using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;
using UnityEngine.UI;

public class ButtonManager : MonoBehaviour {

    private bool gamerunning=true;
    public Sprite startimg;
    public Sprite pauseimg;
    public GameObject GamePausedText;
    public void NewGameBtn(string NewGameLevel)
    {
        AudioManager.getInstance().Play("Theme");
        Time.timeScale = 1;
        SceneManager.LoadScene(NewGameLevel);
        gamerunning = true;

    }
    
    public void ExitGameBtn()
    {
        Application.Quit();
    }

    public void ShopBtn(string NewGameLevel)
    {
        SceneManager.LoadScene(NewGameLevel);
    }
    public void Pausebtn()
    {
        if (gamerunning)
        {
            GameObject.Find("PauseButtn").GetComponent<Button>().GetComponent<Image>().sprite = startimg;
            Time.timeScale = 0;
            gamerunning = false;
            GamePausedText.SetActive(true);
        }
        else
        {
            GameObject.Find("PauseButtn").GetComponent<Button>().GetComponent<Image>().sprite = pauseimg;
            gamerunning = true;
            Time.timeScale = 1;
            GamePausedText.SetActive(false);

        }
        
    }
    public void muteMusic()
    {
        AudioManager.getInstance().mute();
        Config.getInstance().changeSprite();
    }
}
