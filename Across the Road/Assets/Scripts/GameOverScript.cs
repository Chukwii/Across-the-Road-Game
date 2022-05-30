using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOverScript : MonoBehaviour
{
    public bool hasCollide = false;
    
    GameObject[] GameOver;
    GameObject Score;
    
    // Start is called before the first frame update
    void Start()
    {
        Time.timeScale = 1;
        GameOver = GameObject.FindGameObjectsWithTag("gameOver");
        Score = GameObject.FindGameObjectWithTag("score");
        hideFinished();
    }

    // Update is called once per frame
    void Update()
    {
        if(hasCollide == true)
        {
            Score.SetActive(false);
            showFinished();
        }
        
    }

    public void showFinished()
    {
        foreach (GameObject g in GameOver)
        {
            g.SetActive(true);

        }
    }

    public void hideFinished()
    {
        foreach (GameObject g in GameOver)
        {
            g.SetActive(false);
        }
    }
}
