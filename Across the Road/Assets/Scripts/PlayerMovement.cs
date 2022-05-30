using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerMovement : MonoBehaviour
{
    public float speed = 3f;
    Rigidbody2D Rb;
    bool moving = false;
    //public bool isAlive = true;
    
    //public bool check = false;
    

    // Start is called before the first frame update
    void Start()
    {
        Rb = GetComponent<Rigidbody2D>();
        
    }

    // Update is called once per frame
    void Update()
    {

        // player stops or starts movement when button is pressed
        if (Input.GetMouseButtonDown(0) && moving == false)
        {
            //Rb.bodyType = RigidbodyType2D.Dynamic;
            Rb.gravityScale = 0.3f;
            moving = true;
        }
        else if (Input.GetMouseButtonDown(0) && moving == true)
        {
            //Rb.bodyType = RigidbodyType2D.Static;
            Rb.velocity = Vector3.zero;
            Rb.gravityScale = 0f;
            moving = false;
        }
       
        
        /*if(transform.position.y <= -4.16f)
        {
            check = true;
            //Destroy(this.gameObject);

        }*/
        
    }

}
