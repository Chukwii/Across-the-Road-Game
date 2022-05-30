using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playersCollide : MonoBehaviour
{

    void OnTriggerEnter2D(Collider2D col)
    {
        if(col.gameObject.tag == "fakePlayer")
        {
            Destroy(col.gameObject);
        }
    }
}
