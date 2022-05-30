using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameUIManager : MonoBehaviour
{
    GameObject sound;
    // Start is called before the first frame update
    void Start()
    {
        sound = GameObject.FindGameObjectWithTag("sound");
    }

    public void showMenu()
    {
        SceneManager.LoadScene(0);
        Destroy(sound);
    }
}
