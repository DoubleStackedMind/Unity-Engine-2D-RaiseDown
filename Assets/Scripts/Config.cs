using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Config : MonoBehaviour {

    public static Config instance;

    public Sprite mute;
    public Sprite unmute;
    public bool checkForMute = false;
	// Use this for initialization
	void Start () {
        GetComponent<Button>().image.overrideSprite = unmute;
    }

    void Awake()
    {

        if (instance == null)
            instance = this;
        else
        {
            Destroy(gameObject);
            return;
        }
    }

    // Update is called once per frame
    void Update () {
		
	}

    public static Config getInstance()
    {
        return instance;
    }

    public  void changeSprite()
    {
        if(!checkForMute)
        {
            checkForMute = true;
            GetComponent<Button>().image.overrideSprite = mute;
        } else
        {
            checkForMute = false;
            GetComponent<Button>().image.overrideSprite = unmute;
            AudioManager.getInstance().unmute();
        }

    }
}
