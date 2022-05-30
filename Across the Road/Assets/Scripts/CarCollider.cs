using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarCollider : MonoBehaviour
{
    GameOverScript gOP;
    public static bool onVibe;

    void Start()
    {
        gOP = FindObjectOfType<GameOverScript>();
        //onVibe = true;
    }
    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter2D(Collider2D des)
    {
        if (des.gameObject.tag == "Player" || des.gameObject.tag == "secondPlayer")
        {
            Debug.Log("Kill");
            SoundManager.PlaySound("carCollisionSound");
            
            gOP.hasCollide = true;
            Time.timeScale = 0;
            //isAlive = false;
            if (onVibe == true)
            {
                Handheld.Vibrate();
            }
          
        }
    }
    

}
