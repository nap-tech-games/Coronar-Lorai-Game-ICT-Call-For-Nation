using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuScript : MonoBehaviour
{
    AudioSource audio;
    // Start is called before the first frame update
    void Start()
    {
        audio = GameObject.Find("sound").GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ClickPlayButton()
    {
        audio.Play();
        SceneManager.LoadScene("LevelSelection-c#");
    }

    public void ClickHomeButton()
    {
        audio.Play();
        SceneManager.LoadScene("MainMenu");
    }
}
