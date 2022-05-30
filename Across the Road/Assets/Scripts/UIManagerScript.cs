using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class UIManagerScript : MonoBehaviour
{
    GameObject[] Top3;
    GameObject[] Account;
    GameObject[] settings;
    GameObject[] sound;
    ScorScript ss;
    
    // Start is called before the first frame update
    void Start()
    {
        ss = FindObjectOfType<ScorScript>();
        Top3 = GameObject.FindGameObjectsWithTag("Top3");
        Account = GameObject.FindGameObjectsWithTag("account");
        settings = GameObject.FindGameObjectsWithTag("settings");
        sound = GameObject.FindGameObjectsWithTag("sound");
        hideTop3();
        hideAccount();
        hideSettings();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void letVibe()
    {
        CarCollider.onVibe = true;
    }
    public void notVibe()
    {
        CarCollider.onVibe = false;
    }

    public void StartGame()
    { 
        SceneManager.LoadScene(1);
    }

    public void menuStart()
    {
        //ScorScript.firstAccout = true;
        SceneManager.LoadScene(0);
    }

    public void menuStart2()
    {
        //ScorScript.secondAccout = true;
        SceneManager.LoadScene(0);
    }

    public void showTop3()
    {
        foreach (GameObject g in Top3)
        {
            g.SetActive(true);

        }
    }
    public void hideTop3()
    {
        foreach (GameObject g in Top3)
        {
            g.SetActive(false);

        }
    }

    public void showAccount()
    {
        foreach (GameObject g in Account)
        {
            g.SetActive(true);

        }
    }
    public void hideAccount()
    {
        foreach (GameObject g in Account)
        {
            g.SetActive(false);

        }
    }
    public void showSettings()
    {
        foreach (GameObject g in settings)
        {
            g.SetActive(true);

        }
    }
    public void hideSettings()
    {
        foreach (GameObject g in settings)
        {
            g.SetActive(false);

        }
    }
    public void showSound()
    {
        foreach (GameObject g in sound)
        {
            g.SetActive(true);

        }
    }
    public void hideSound()
    {
        foreach (GameObject g in sound)
        {
            g.SetActive(false);

        }
    }
}
