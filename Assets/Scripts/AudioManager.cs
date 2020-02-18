
using System;
using UnityEngine;

public class AudioManager : MonoBehaviour {

    public Sound[] sounds;

    public static AudioManager instance;
	// Use this for initialization
	void Awake () {

        if (instance == null)
            instance = this;
        else
        {
            Destroy(gameObject);
            return;
        }
            DontDestroyOnLoad(gameObject);

		foreach(Sound s in sounds) {
           s.source = gameObject.AddComponent<AudioSource>();
            s.source.clip = s.clip;
            s.source.volume = s.volume;
            s.source.pitch = s.pitch;
            s.source.loop = s.loop;
        }
	}

    void Start()
    {
      //  Play("Theme");
    }
	
	// Update is called once per frame
	public void Play (String name) {
       Sound s = Array.Find(sounds, sound => sound.name == name);
        if (s == null)
        {
            Debug.LogWarning("Error sound "+ s +" does not exist!");
            return;
        }
        s.source.Play();    
	}
    public void Stop(String name)
    {
        Sound s = Array.Find(sounds, sound => sound.name == name);
        if (s == null)
        {
            Debug.LogWarning("Error sound " + s + " does not exist!");
            return;
        }
        s.source.Stop();
    }
    public static AudioManager getInstance()
    {
        return instance;
    }


    public void mute()
    {
        Sound s = Array.Find(sounds, sound => sound.name == "Theme");
        s.source.volume = 0;
    }
    public void unmute()
    {
        Sound s = Array.Find(sounds, sound => sound.name == "Theme");
        s.source.volume = 0.4f;
    }
}
