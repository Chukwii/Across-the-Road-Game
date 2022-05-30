using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
    public static AudioClip colWithCarSound;
    static AudioSource audioScr;
    // Start is called before the first frame update
    void Start()
    {
        //menuGameSound = Resourses.Load<AudioClip>("gameSound");
        colWithCarSound = Resources.Load<AudioClip>("carCollisionSound");
        
        audioScr = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public static void PlaySound(string clip)
    {
        switch (clip)
        {
           /* case "gameSound":
                audioScr.PlayOneShot(menuGameSound);
                break;*/
            case "carCollisionSound":
                audioScr.PlayOneShot(colWithCarSound);
                break;
                /* case "click":
                    audioScr.PlayOneShot(clickSound);
                    break; */
        }
    }
}
