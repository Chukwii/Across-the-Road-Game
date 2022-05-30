using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScorScript : MonoBehaviour
{

    public Text scoreText;
    public int Score;
    public int Score1;
    public int Score2;
    public int Score3;

    //public int secondScore;
    //public int secondScore1;
    //public int secondScore2;
    //public int secondScore3;

    public Text NewText;
    public Text highScore;
    public Text firstHigh;
    public Text secondHigh;
    public Text thirdHigh;

    //public Text secondhighScore;
   // public Text secondfirstHigh;
    //public Text secondsecondHigh;
    //public Text secondthirdHigh;

    //public static bool firstAccout = false;
    //public static bool secondAccout = false;

    //GameObject[] oneUser;
    //GameObject[] twoUser;
    // Start is called before the first frame update
    void Start()
    {
        //oneUser = GameObject.FindGameObjectsWithTag("oneUser");
        //twoUser = GameObject.FindGameObjectsWithTag("twoUser");


            highScore.text = PlayerPrefs.GetInt("HighScore", 0).ToString();
            thirdHigh.text = PlayerPrefs.GetInt("HighScore1", 0).ToString();
            secondHigh.text = PlayerPrefs.GetInt("HighScore2", 0).ToString();
            firstHigh.text = PlayerPrefs.GetInt("HighScore3", 0).ToString();
 
        
       
            //highScore.text = PlayerPrefs.GetInt("HighScore", 0).ToString();
           // secondthirdHigh.text = PlayerPrefs.GetInt("secondHighScore1", 0).ToString();
           // secondsecondHigh.text = PlayerPrefs.GetInt("secondHighScore2", 0).ToString();
           // secondfirstHigh.text = PlayerPrefs.GetInt("secondHighScore3", 0).ToString();
           // hideUser1();
           // showUser2();
        

        
    }

    // Update is called once per frame
    void Update()
    {
        scoreText.text = Score.ToString();
        NewText.text = Score.ToString();

        if (Score >= PlayerPrefs.GetInt("HighScore", 0))
        {
            // set high score

            PlayerPrefs.SetInt("HighScore", Score);
            highScore.text = Score.ToString();

        }

        if (Score > PlayerPrefs.GetInt("HighScore1", 0) && Score < PlayerPrefs.GetInt("HighScore2", 0) && Score < PlayerPrefs.GetInt("HighScore3", 0))
        {
            Score1 = Score;
            //PlayerPrefs.GetInt("HighScore1", 0);
            PlayerPrefs.SetInt("HighScore1", Score1);
            PlayerPrefs.Save();
            thirdHigh.text = Score1.ToString();

        }

        if (PlayerPrefs.GetInt("HighScore2", 0) < Score && Score < PlayerPrefs.GetInt("HighScore3", 0))
        {
            if (PlayerPrefs.GetInt("HighScore1", 0) < PlayerPrefs.GetInt("HighScore2", 0))
            {
                Score1 = Score2;
            }

            Score2 = Score;
            //PlayerPrefs.GetInt("HighScore2", 0);
            PlayerPrefs.SetInt("HighScore2", Score2);
            PlayerPrefs.Save();
            secondHigh.text = Score2.ToString();

        }

        if (PlayerPrefs.GetInt("HighScore3", 0) < Score)
        {
            if (PlayerPrefs.GetInt("HighScore1", 0) < PlayerPrefs.GetInt("HighScore2", 0))
            {
                Score1 = Score2;
            }
            if (PlayerPrefs.GetInt("HighScore2", 0) < PlayerPrefs.GetInt("HighScore3", 0))
            {
                Score2 = Score3;
            }

            Score3 = Score;
            //PlayerPrefs.GetInt("HighScore3", 0);
            PlayerPrefs.SetInt("HighScore3", Score3);
            PlayerPrefs.Save();
            firstHigh.text = Score3.ToString();

        }
    }

    /*void userOne()
    {
        if (Score >= PlayerPrefs.GetInt("HighScore", 0))
        {
            // set high score

            PlayerPrefs.SetInt("HighScore", Score);
            highScore.text = Score.ToString();

        }

        if (Score > PlayerPrefs.GetInt("HighScore1", 0) && Score < PlayerPrefs.GetInt("HighScore2", 0) && Score < PlayerPrefs.GetInt("HighScore3", 0))
        {
            Score1 = Score;
            //PlayerPrefs.GetInt("HighScore1", 0);
            PlayerPrefs.SetInt("HighScore1", Score1);
            PlayerPrefs.Save();
            thirdHigh.text = Score1.ToString();

        }

        if (PlayerPrefs.GetInt("HighScore2", 0) < Score && Score < PlayerPrefs.GetInt("HighScore3", 0))
        {
            if (PlayerPrefs.GetInt("HighScore1", 0) < PlayerPrefs.GetInt("HighScore2", 0))
            {
                Score1 = Score2;
            }

            Score2 = Score;
            //PlayerPrefs.GetInt("HighScore2", 0);
            PlayerPrefs.SetInt("HighScore2", Score2);
            PlayerPrefs.Save();
            secondHigh.text = Score2.ToString();

        }

        if (PlayerPrefs.GetInt("HighScore3", 0) < Score)
        {
            if (PlayerPrefs.GetInt("HighScore1", 0) < PlayerPrefs.GetInt("HighScore2", 0))
            {
                Score1 = Score2;
            }
            if (PlayerPrefs.GetInt("HighScore2", 0) < PlayerPrefs.GetInt("HighScore3", 0))
            {
                Score2 = Score3;
            }

            Score3 = Score;
            //PlayerPrefs.GetInt("HighScore3", 0);
            PlayerPrefs.SetInt("HighScore3", Score3);
            PlayerPrefs.Save();
            firstHigh.text = Score3.ToString();

        }
    }
   
    void userTwo()
    {
        if (Score >= PlayerPrefs.GetInt("HighScore", 0))
        {
            // set high score

            PlayerPrefs.SetInt("HighScore", Score);
            highScore.text = Score.ToString();

        }

        if (Score > PlayerPrefs.GetInt("secondHighScore1", 0) && Score < PlayerPrefs.GetInt("secondHighScore2", 0) && Score < PlayerPrefs.GetInt("secondHighScore3", 0))
        {
            secondScore1 = Score;
            //PlayerPrefs.GetInt("HighScore1", 0);
            PlayerPrefs.SetInt("secondHighScore1", secondScore1);
            PlayerPrefs.Save();
            thirdHigh.text = secondScore1.ToString();

        }

        if (PlayerPrefs.GetInt("secondHighScore2", 0) < Score && Score < PlayerPrefs.GetInt("secondHighScore3", 0))
        {
            if (PlayerPrefs.GetInt("secondHighScore1", 0) < PlayerPrefs.GetInt("secondHighScore2", 0))
            {
                secondScore1 = secondScore2;
            }

            secondScore2 = Score;
            //PlayerPrefs.GetInt("HighScore2", 0);
            PlayerPrefs.SetInt("secondHighScore2", secondScore2);
            PlayerPrefs.Save();
            secondsecondHigh.text = secondScore2.ToString();

        }

        if (PlayerPrefs.GetInt("secondHighScore3", 0) < Score)
        {
            if (PlayerPrefs.GetInt("secondHighScore1", 0) < PlayerPrefs.GetInt("secondHighScore2", 0))
            {
                secondScore1 = secondScore2;
            }
            if (PlayerPrefs.GetInt("secondHighScore2", 0) < PlayerPrefs.GetInt("secondHighScore3", 0))
            {
                secondScore2 = secondScore3;
            }

            secondScore3 = Score;
            //PlayerPrefs.GetInt("HighScore3", 0);
            PlayerPrefs.SetInt("secondHighScore3", secondScore3);
            PlayerPrefs.Save();
            firstHigh.text = secondScore3.ToString();

        }
    }
    */
    

}
