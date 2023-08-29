using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SettingsSc : MonoBehaviour
{
    public GameObject musicToggleOn;
    public GameObject musicToggleOff;
    int music;
    int sound;

    public GameObject soundToggleOn;
    public GameObject soundToggleOff;

    public GameObject settingsCanv;
    // Start is called before the first frame update
    void Start()
    {
        int musicB = PlayerPrefs.GetInt("music");
        int soundB = PlayerPrefs.GetInt("sound");
      
        if (musicB == 0)
        {
            Debug.Log("Music is OFF");
            AudioListener.pause = true;
            musicToggleOn.SetActive(false);
            musicToggleOff.SetActive(true);
        }
        else
        {
            Debug.Log("Music is ON");
            AudioListener.pause = false;
            musicToggleOn.SetActive(true); 
            musicToggleOff.SetActive(false);
        }
        if (soundB == 0)
        {
            AudioListener.pause = true;
            Debug.Log("Sound is OFF");
            soundToggleOn.SetActive(false);
            soundToggleOff.SetActive(true);
        }
        else
        {
            AudioListener.pause = false;
            Debug.Log("Sound is ON");
            soundToggleOn.SetActive(true);
            soundToggleOff.SetActive(false);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
            if (Input.GetKeyDown(KeyCode.Escape))
            {
                if (settingsCanv.activeInHierarchy == true)
                {
                    settingsCanv.SetActive(false);
                   
                }
                else
                {
                    Application.Quit();
                  
                }

            }
           
        
    }
  
    public void settingsToggle()
    {
        if (settingsCanv.activeInHierarchy == true)
        {
            settingsCanv.SetActive(false);
            
        }
        else
        {
            settingsCanv.SetActive(true);
        }
    }
   public void musicToggle()
    {
        if (musicToggleOn.activeInHierarchy == true)
        {
            musicToggleOn.SetActive(false);
            musicToggleOff.SetActive(true);
            PlayerPrefs.SetInt("music", 0);
        }
        else
        {
            musicToggleOn.SetActive(true);
            musicToggleOff.SetActive(false);
           
            PlayerPrefs.SetInt("music", 1);
            Debug.Log("Music = 1!");
        }
    }
    public void soundToggle()
    {
        if (soundToggleOn.activeInHierarchy == true)
        {
            soundToggleOn.SetActive(false);
            soundToggleOff.SetActive(true);
            AudioListener.pause = true;
           
            PlayerPrefs.SetInt("sound", 0);
            Debug.Log("Sound is OFF");
        }
        else
        {
            soundToggleOn.SetActive(true);
            soundToggleOff.SetActive(false);
            PlayerPrefs.SetInt("sound", 1);
            Debug.Log("Sound = 1!");
            AudioListener.pause = false; 
        }
    }
    public void quitf()
    {
        Application.Quit();

    }
}
